Lab 10 1;

// Подсистема AudioSystem для управления звуком
public class AudioSystem
{
    public void TurnOn()
    {
        Console.WriteLine("Audio system is turned on.");
    }

    public void SetVolume(int level)
    {
        Console.WriteLine($"Audio volume is set to {level}.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Audio system is turned off.");
    }
}

// Подсистема VideoProjector для управления видео
public class VideoProjector
{
    public void TurnOn()
    {
        Console.WriteLine("Video projector is turned on.");
    }

    public void SetResolution(string resolution)
    {
        Console.WriteLine($"Video resolution is set to {resolution}.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Video projector is turned off.");
    }
}

// Подсистема LightingSystem для управления освещением
public class LightingSystem
{
    public void TurnOn()
    {
        Console.WriteLine("Lights are turned on.");
    }

    public void SetBrightness(int level)
    {
        Console.WriteLine($"Lights brightness is set to {level}.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Lights are turned off.");
    }
}

// Фасад для упрощенного управления системой домашнего кинотеатра
public class HomeTheaterFacade
{
    private AudioSystem _audioSystem;
    private VideoProjector _videoProjector;
    private LightingSystem _lightingSystem;

    public HomeTheaterFacade(AudioSystem audioSystem, VideoProjector videoProjector, LightingSystem lightingSystem)
    {
        _audioSystem = audioSystem;
        _videoProjector = videoProjector;
        _lightingSystem = lightingSystem;
    }

    // Метод для начала просмотра фильма
    public void StartMovie()
    {
        Console.WriteLine("Preparing to start the movie...");
        _lightingSystem.TurnOn();
        _lightingSystem.SetBrightness(5); // Установка яркости
        _audioSystem.TurnOn();
        _audioSystem.SetVolume(8); // Установка громкости
        _videoProjector.TurnOn();
        _videoProjector.SetResolution("HD"); // Установка разрешения
        Console.WriteLine("Movie started.");
    }

    // Метод для завершения просмотра фильма
    public void EndMovie()
    {
        Console.WriteLine("Shutting down movie...");
        _videoProjector.TurnOff();
        _audioSystem.TurnOff();
        _lightingSystem.TurnOff();
        Console.WriteLine("Movie ended.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание подсистем
        AudioSystem audio = new AudioSystem();
        VideoProjector video = new VideoProjector();
        LightingSystem lights = new LightingSystem();

        // Создание фасада
        HomeTheaterFacade homeTheater = new HomeTheaterFacade(audio, video, lights);

        // Запуск фильма
        homeTheater.StartMovie();
        Console.WriteLine();

        // Завершение фильма
        homeTheater.EndMovie();
    }
}
