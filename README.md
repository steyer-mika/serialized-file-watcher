# SerializedFileWatcher

SerializedFileWatcher is a .NET project designed to monitor specified directories for changes in files and perform serialization on those files when changes are detected.

## Features

- **File Monitoring**: Continuously monitors specified directories for changes in files.
- **Serialization**: Automatically serializes files upon detection of changes.
- **Cross-Platform**: Compatible with .NET, making it runnable on Windows, macOS, and Linux.

## Installation

1. Clone the repository:

```
git clone https://github.com/steyer-mika/SerializedFileWatcher.git
```

2. Build the project:

```
cd SerializedFileWatcher
dotnet build
```

## Usage

1. Configure the application by editing the `appsettings.json` file to specify the directories you want to monitor and the serialization settings.

2. Run the application:

```
dotnet run
```

3. Sit back and let SerializedFileWatcher handle the monitoring and serialization of your files!

## Configuration

You can customize the behavior of SerializedFileWatcher by modifying the `appsettings.json` file. Here are some of the key configurations:

- `DirectoriesToWatch`: An array of directories to monitor for file changes.
- `SerializationSettings`: Configuration options for serialization, such as the serialization format (e.g., JSON, XML), output directory, etc.

Example `appsettings.json`:

```json
{
  "DirectoriesToWatch": [
    "/path/to/directory1",
    "/path/to/directory2"
  ],
  "SerializationSettings": {
    "Format": "JSON",
    "OutputDirectory": "/path/to/serialized_files"
  }
}
```

## Contributing

Contributions are welcome! If you'd like to contribute to SerializedFileWatcher, please fork the repository, make your changes, and submit a pull request. For major changes, please open an issue first to discuss the proposed changes.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- Inspired by the need for a simple yet powerful file watcher with serialization capabilities.
