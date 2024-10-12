# League of Legends Client (WPF)

[![English](https://img.shields.io/badge/docs-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/docs-中文-red.svg)](README.zh-CN.md) [![한국어](https://img.shields.io/badge/docs-한국어-green.svg)](README.ko.md)

This is a high-quality reproduction project of the League of Legends client using WPF. The project includes various technical implementations of WPF and demonstrates a broad technical approach to the distributed design of large-scale projects.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnetgroup/leagueoflegends-wpf.svg)](https://github.com/jamesnetgroup/leagueoflegends-wpf/stargazers)
[![Forks](https://img.shields.io/github/forks/jamesnetgroup/leagueoflegends-wpf.svg)](https://github.com/jamesnetgroup/leagueoflegends-wpf/network/members)
[![Issues](https://img.shields.io/github/issues/jamesnetgroup/leagueoflegends-wpf.svg)](https://github.com/jamesnetgroup/leagueoflegends-wpf/issues)

#### League of Legends XAML-Based Series:
<div style="text-align: center;">
    <img src="https://jamesnetdev.blob.core.windows.net/articleimages/543a4bd8-ace3-4d1a-acab-36f5b7f8b200.png" width="8%"/>
    <img src="https://jamesnetdev.blob.core.windows.net/articleimages/0d8bd5b4-c898-4bcf-af91-b4267551934f.png" width="20%"/>
    <img src="https://jamesnetdev.blob.core.windows.net/articleimages/77eaa9cd-865b-430d-89c6-0e10ead0abd5.png" width="8%"/>
</div>

<br/>

[League of Legends Client (WPF)](https://github.com/jamesnetgroup/leagueoflegends-wpf)  
[League of Legends Client (Uno-Platform)](https://github.com/jamesnetgroup/leagueoflegends-uno)  
[League of Legends Client (WinUI 3)](https://github.com/jamesnetgroup/leagueoflegends-winui3)

## Project Introduction

We have been researching and gaining experience with WPF technology since 2008. Over the years, various XAML-based cross-platform technologies such as Xamarin, MAUI, Uno-Platform, AvaloniaUI, and OpenSilver have evolved, opening up possibilities to extend the techniques accumulated in WPF to cross-platform development.

This League of Legends WPF version we are releasing is built on the foundation of XAML-based rich UX, C#'s object-oriented design, and a systematic project structure. It maximizes the powerful features of WPF while considering the potential for future expansion to other XAML-based platforms.

This project demonstrates how to implement large-scale projects in WPF. By implementing complex controls as CustomControls, we aim to provide developers with rich learning materials. It also includes various technical implementation cases of WPF, showing how to utilize WPF's powerful features in real projects.

In particular, this project presents a broad approach to the distributed design of large-scale applications. It shows how to structure and manage complex applications through modularized structures, efficient state management, and scalable architecture.

The Jamesnet.Core framework library is designed based on .NET Standard 2.0 to work identically in WPF and Uno. This library is provided as Jamesnet.Window for WPF and Jamesnet.Uno for Uno-Platform.

This project directly references the actual source code of Jamesnet.Core and Jamesnet.Window, allowing you to learn about the design methods of XAML-based frameworks.

Through this project, we aim to showcase the powerful features of WPF while presenting the possibility of expansion to various XAML-based platforms such as Uno-Platform, MAUI, AvaloniaUI, OpenSilver, and WinUI3 in the future, opening new horizons for cross-platform development.

<img src="https://github.com/user-attachments/assets/3bc0d881-577e-4aa2-8802-698169d701a5" width="49%"/>
<img src="https://github.com/user-attachments/assets/d3b13869-d0f8-457d-90d9-5a637c500b4a" width="49%"/>
<img src="https://github.com/user-attachments/assets/45920f83-41b9-4924-8e92-86123d15a2a4" width="49%"/>
<img src="https://github.com/user-attachments/assets/4e41c4af-1a98-48b0-9c44-05ac48f0430e" width="49%"/>
<img src="https://github.com/user-attachments/assets/78415f9d-732c-4940-881c-beed7a6e9620" width="49%"/>
<img src="https://github.com/user-attachments/assets/b376f4ed-4ffd-4528-b1cc-6b0483f442e1" width="49%"/>
<img src="https://github.com/user-attachments/assets/3bc0d881-577e-4aa2-8802-698169d701a5" width="49%"/>
<img src="https://github.com/user-attachments/assets/0cedb504-2f27-43b8-87ed-34e85f1d7b83" width="49%"/>
<img src="https://github.com/user-attachments/assets/f5e80933-9d18-47c1-81c6-eb55a680972a" width="49%"/>
<img src="https://github.com/user-attachments/assets/d8aa51d5-c6e1-4a9a-95f8-e20a7c6f9f91" width="49%"/>
<img src="https://github.com/user-attachments/assets/c2cc6c22-8345-4333-83a2-61ab08883652" width="49%"/>
<img src="https://github.com/user-attachments/assets/fd6aa0ca-14c1-4446-b6cb-2617bc15b373" width="49%"/>
<img src="https://github.com/user-attachments/assets/be84fe63-4fb5-4a6c-a537-9907b88e648b" width="49%"/>
<img src="https://github.com/user-attachments/assets/24db2d8b-b839-42b2-be8a-2fc6266dad77" width="49%"/>
<img src="https://github.com/user-attachments/assets/642ccf0d-f2df-4adc-bb87-b1246cbda0b7" width="49%"/>
<img src="https://github.com/user-attachments/assets/bece2bfd-1bb9-436e-b928-929d3706398c" width="49%"/>

## Core Technology Stack
> The repository includes all framework source code.

- [x] **Jamesnet.Core**: Cross-platform core library based on .NET Standard 2.0
- [x] **Jamesnet.Windows**: Window management and UI framework optimized for WPF

These two libraries can be used identically in both WPF and Uno-Platform, and include all core functionalities necessary for the architectural design of large-scale projects.

## Key Features and Implementations

1. **Large-scale Project Architecture**
   - [x] Modular and distributed system design
   - [x] Loose coupling through dependency injection
   - [x] Plugin-based extensible structure

2. **Advanced WPF Techniques**
   - [x] Implementation of various CustomControls
   - [x] Complex state management using VisualStateManager
   - [x] Data virtualization and UI virtualization techniques

3. **Performance Optimization**
   - [x] Efficient resource management and memory usage
   - [x] Application of asynchronous programming patterns
   - [x] Rendering optimization techniques

4. **UI/UX Design**
   - [x] Implementation of complex graphics using Geometry Path
   - [x] Custom animations and transition effects
   - [x] Dynamic theme system

5. **Framework Design**
   - [x] Event-based communication system
   - [x] Implementation of state management patterns
   - [x] Extensible navigation system

This project comprehensively showcases advanced design patterns and techniques based on Jamesnet.Core and Jamesnet.Window while maximizing the powerful features of WPF. By providing real-world application cases of various technologies and patterns necessary for large-scale application development, it will serve as rich learning material for WPF developers.

We hope this project will inspire WPF developers and serve as a best practice for large-scale desktop application development. Furthermore, we expect that through this project, we can explore code sharing strategies between WPF and [Uno-Platform](https://github.com/jamesnetgroup/leagueoflegends-uno) and new possibilities in cross-platform development.

> We are planning versions for new platforms such as MAUI, WinUI 3, AvaloniaUI, and OpenSilver in the future.

## Technology Stack
- .NET 8.0
- WPF (Windows Presentation Foundation)
- Jamesnet.Core
- Jamesnet.Windows
- Jamesnet.Uno

## Getting Started
### Prerequisites
- Visual Studio 2022 or later
- .NET 8.0 SDK
- Jamesnet.Wpf NuGet package

### Installation and Execution
#### 1. Clone the repository:

```
git clone https://github.com/jamesnet214/leagueoflegends.git
```

#### 2. Open the solution
- [x] Visual Studio
- [x] Visual Studio Code
- [x] JetBrains Rider

<img src="https://github.com/user-attachments/assets/af70f422-7057-4e77-a54d-042ee8358d2a" width="32%"/>
<img src="https://github.com/user-attachments/assets/e4feaa10-a107-4b58-8d13-1d8be620ec62" width="32%"/>
<img src="https://github.com/user-attachments/assets/5ff487f6-55e4-43e1-9abf-f8d419ee6943" width="32%"/>

#### 3. Build and Run
- [x] Set the startup project
- [x] Press F5 or click the Run button
- [x] Windows 11 recommended

## Learning Opportunities
This project offers valuable insights for WPF developers:
1. **Complex UI Recreation**: Learn techniques for recreating sophisticated user interfaces
2. **Custom Control Development**: Understand the process of building custom WPF controls
3. **MVVM in Practice**: See real-world implementation of MVVM pattern in a complex application
4. **Geometry Path Usage**: Master the use of Geometry Path for intricate UI designs
5. **Performance Optimization**: Learn strategies for optimizing large-scale WPF applications

## Contributing
Contributions to the League of Legends Client (WPF) project are welcome! Feel free to submit issues, create pull requests, or suggest improvements.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact
- Website: https://jamesnet.dev
- Email: james@jamesnet.dev, vickyqu115@hotmail.com

Experience the power of WPF in recreating complex game interfaces with this League of Legends client recreation!
