# DiskScope

**Understand what's taking up space.**

DiskScope is a free, open-source disk space analyser designed to help users understand how their storage is being used.

The goal is to provide a clear, modern and intuitive way to explore drives, analyse files and identify where storage space is going.

> 🚧 **Early development:** DiskScope is currently in its initial development stage. Features and documentation will evolve as the project progresses.

## Goals

DiskScope aims to be:

- **Free and open source** – No paid features or artificial limitations.
- **Privacy-focused** – Your files and storage information stay on your device.
- **Easy to understand** – Clear visualisations and useful storage information.
- **Lightweight** – Efficient scanning without unnecessary overhead.
- **Cross-platform by design** – Initially targeting Windows, with an architecture intended to support Linux and macOS in the future.

## Planned Features

- [ ] Drive discovery and storage overview
- [ ] Used and available storage breakdowns
- [ ] Directory and file analysis
- [ ] Visual treemap representation of storage usage
- [ ] File type categorisation
- [ ] Sort and filter files by size and type
- [ ] Scan progress reporting
- [ ] Scan cancellation
- [ ] Permission and inaccessible directory handling
- [ ] Light and dark themes

## Technology Stack

| Technology | Purpose |
|---|---|
| C# | Primary programming language |
| .NET 10 | Application runtime |
| Avalonia UI | Cross-platform desktop interface |
| CommunityToolkit.Mvvm | MVVM implementation |

## Project Structure

```text
DiskScope/
├── src/
│   ├── DiskScope.App/
│   ├── DiskScope.Core/
│   └── DiskScope.Infrastructure/
├── tests/
│   └── DiskScope.Tests/
├── docs/
├── DiskScope.sln
└── README.md
```

### Architecture

DiskScope follows a layered architecture:

- **DiskScope.App** – Desktop application, UI and presentation logic.
- **DiskScope.Core** – Core domain models, abstractions and business logic.
- **DiskScope.Infrastructure** – Storage discovery, file system access and external implementations.
- **DiskScope.Tests** – Automated tests.

The core project is independent of the UI framework and infrastructure implementation.

## Getting Started

### Requirements

- Windows 11 (initial development target)
- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

### Building

Clone the repository:

```bash
git clone https://github.com/ItsMochabara/DiskScope.git
cd DiskScope
```

Build the solution:

```bash
dotnet build
```

Run the application:

```bash
dotnet run --project src/DiskScope.App
```

Run tests:

```bash
dotnet test
```

## Roadmap

Development will initially focus on establishing the application foundation before implementing storage analysis functionality.

1. Project foundation and application shell
2. Drive discovery and storage information
3. Directory scanning
4. File analysis and categorisation
5. Treemap visualisation
6. Search, sorting and filtering
7. Testing, polish and initial release

## Contributing

Contributions, bug reports and suggestions are welcome.

Please open an issue to discuss significant changes before submitting a pull request.

## Licence

A licence will be selected before the first public release.

---

**DiskScope** is part of the MochaByte open-source software portfolio.

*Software brewed with purpose.*
