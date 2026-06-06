using Mtf.Extensions;
using Mtf.Lego.Mindstorms.EV3.Commands.Speaker;
using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Resources;
using Mtf.Music;

namespace Mtf.Lego.Mindstorms.EV3.EV3;

public partial class Brick
{
    public void Beep(ushort frequency, ushort duration)
    {
        Execute(new Beep(Volume, frequency, duration));
    }

    public void BeepAndWait(ushort frequency, ushort duration)
    {
        ExecuteAndWait(new Beep(Volume, frequency, duration));
    }

    public void Silence()
    {
        musicPlayerCancellationTokenSource.Cancel();
        Execute(new Silence());
    }

    public bool SpeakerIsBusy()
    {
        var response = Execute(new SpeakerIsBusy());
        return response.RawResponseData[^1] != 0;
    }

    public void PlayNote(string note, ushort durationMs = Constants.DefaultNoteDurationMs)
    {
        Execute(new PlayNote(Volume, note, durationMs));
    }

    public void PlayMusic(Melody melody)
    {
        if (CurrentlyPlayedMelody != null)
        {
            return;
        }

        musicPlayerCancellationTokenSource = new CancellationTokenSource();
        Task.Factory.StartNew(() =>
        {
            lock (soundPlayLock)
            {
                CurrentlyPlayedMelody = melody;

                if (melody.Notes != null)
                {
                    foreach (var note in melody.Notes)
                    {
                        if (musicPlayerCancellationTokenSource.IsCancellationRequested)
                        {
                            break;
                        }

                        ClearScreen();
                        ShowOnMiddleOfScreen(note, FontType.Big, 0);
                        ExecuteAndWait(new PlayNote(Volume, note));
                    }
                }
                else
                {
                    foreach (var note in melody)
                    {
                        if (musicPlayerCancellationTokenSource.IsCancellationRequested)
                        {
                            break;
                        }

                        var duration = melody.GetNoteLength(note.NoteType);
                        if (note is Fermata)
                        {
                            Thread.Sleep(duration);
                        }
                        else
                        {
                            ClearScreen();
                            ShowOnMiddleOfScreen(note.Name, FontType.Big, 0);
                            ExecuteAndWait(new Beep(Volume, note, duration));
                        }
                    }
                }

                CurrentlyPlayedMelody = null;
            }
        }, musicPlayerCancellationTokenSource.Token);
    }

    public void PlaySound(string soundFilePath, bool repeat = false)
    {
        Execute(new PlaySound(Volume, soundFilePath, repeat));
    }

    public void PlaySound(EmbeddedSound embeddedSound, PlayType playType)
    {
        var description = embeddedSound.GetDescription();
        var file = ResourceUploader.UploadSound(this, $"{description}{Constants.SoundFileExtension}");
        var repeat = playType == PlayType.Repeat;
        Execute(new PlaySound(Volume, file, repeat));
        if (playType == PlayType.WaitForCompletion)
        {
            while (SpeakerIsBusy())
            {
                Thread.Sleep(300);
            }
        }
    }
}
