# 英雄联盟客户端 (WPF)

[![English](https://img.shields.io/badge/docs-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/docs-中文-red.svg)](README.zh-CN.md) [![한국어](https://img.shields.io/badge/docs-한국어-green.svg)](README.ko.md)

这是一个使用WPF技术高质量重现英雄联盟客户端的项目。该项目包含了WPF的各种技术实现，展示了大型项目分布式设计的广泛技术方法。

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnetgroup/leagueoflegends-wpf.svg)](https://github.com/jamesnetgroup/leagueoflegends-wpf/stargazers)
[![Forks](https://img.shields.io/github/forks/jamesnetgroup/leagueoflegends-wpf.svg)](https://github.com/jamesnetgroup/leagueoflegends-wpf/network/members)
[![Issues](https://img.shields.io/github/issues/jamesnetgroup/leagueoflegends-wpf.svg)](https://github.com/jamesnetgroup/leagueoflegends-wpf/issues)

#### 英雄联盟 XAML-Based 系列：
[英雄联盟客户端 (WPF)](https://github.com/jamesnetgroup/leagueoflegends-wpf)  
[英雄联盟客户端 (Uno-Platform)](https://github.com/jamesnetgroup/leagueoflegends-uno)

## 项目介绍

我们从2008年开始研究和积累WPF技术经验。这些年来，Xamarin、MAUI、Uno-Platform、AvaloniaUI、OpenSilver等各种基于XAML的跨平台技术不断发展，为我们将在WPF中积累的技术扩展到跨平台开发提供了可能性。

这次发布的英雄联盟WPF版本基于XAML的丰富UX、C#的面向对象设计以及系统化的项目结构构建而成。它充分利用了WPF的强大功能，同时考虑了未来向其他基于XAML的平台扩展的可能性。

该项目展示了如何在WPF中实现大型项目。通过将复杂的控件实现为CustomControl，我们旨在为开发者提供丰富的学习材料。此外，它还包含了WPF的各种技术实现案例，展示了如何在实际项目中利用WPF的强大功能。

特别是，该项目提出了大型应用程序分布式设计的广泛方法。通过模块化结构、高效的状态管理以及可扩展的架构，展示了如何构建和管理复杂的应用程序。

Jamesnet.Core框架库基于.NET Standard 2.0设计，可以在WPF和Uno中同样运行。这个库在WPF中以Jamesnet.Window的形式提供，在Uno-Platform中以Jamesnet.Uno的形式提供。

该项目直接引用了Jamesnet.Core和Jamesnet.Window的实际源代码，使你能够学习基于XAML的框架的设计方法。

通过这个项目，我们旨在展示WPF的强大功能，同时提出未来向Uno-Platform、MAUI、AvaloniaUI、OpenSilver、WinUI3等各种基于XAML的平台扩展的可能性，开辟跨平台开发的新视野。

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

## 核心技术栈
> 仓库中包含所有框架源代码。

- [x] **Jamesnet.Core**: 基于.NET Standard 2.0的跨平台核心库
- [x] **Jamesnet.Windows**: 为WPF优化的窗口管理和UI框架

这两个库可以在WPF和Uno-Platform中同样使用，并包含了大型项目架构设计所需的所有核心功能。

## 主要功能和实现

1. **大型项目架构**
   - [x] 模块化和分布式系统设计
   - [x] 通过依赖注入实现松耦合
   - [x] 基于插件的可扩展结构

2. **高级WPF技术**
   - [x] 实现各种CustomControl
   - [x] 使用VisualStateManager进行复杂状态管理
   - [x] 数据虚拟化和UI虚拟化技术

3. **性能优化**
   - [x] 高效的资源管理和内存使用
   - [x] 应用异步编程模式
   - [x] 渲染优化技术

4. **UI/UX设计**
   - [x] 使用Geometry Path实现复杂图形
   - [x] 自定义动画和转场效果
   - [x] 动态主题系统

5. **框架设计**
   - [x] 基于事件的通信系统
   - [x] 实现状态管理模式
   - [x] 可扩展的导航系统

该项目充分利用WPF的强大功能，同时全面展示了基于Jamesnet.Core和Jamesnet.Window的高级设计模式和技术。通过提供大型应用程序开发所需的各种技术和模式的实际应用案例，它将成为WPF开发者的丰富学习材料。

我们希望这个项目能够激发WPF开发者的灵感，并成为大型桌面应用程序开发的最佳实践。此外，我们期望通过这个项目，能够探索WPF和[Uno-Platform](https://github.com/jamesnetgroup/leagueoflegends-uno)之间的代码共享策略以及跨平台开发的新可能性。

> 我们计划在未来开发MAUI、WinUI 3、AvaloniaUI、OpenSilver等新平台版本。

## 技术栈
- .NET 8.0
- WPF (Windows Presentation Foundation)
- Jamesnet.Core
- Jamesnet.Windows
- Jamesnet.Uno

## 入门指南
### 前置条件
- Visual Studio 2022或更高版本
- .NET 8.0 SDK
- Jamesnet.Wpf NuGet包

### 安装和执行
#### 1. 克隆仓库：

```
git clone https://github.com/jamesnet214/leagueoflegends.git
```

#### 2. 打开解决方案
- [x] Visual Studio
- [x] Visual Studio Code
- [x] JetBrains Rider

<img src="https://github.com/user-attachments/assets/af70f422-7057-4e77-a54d-042ee8358d2a" width="32%"/>
<img src="https://github.com/user-attachments/assets/e4feaa10-a107-4b58-8d13-1d8be620ec62" width="32%"/>
<img src="https://github.com/user-attachments/assets/5ff487f6-55e4-43e1-9abf-f8d419ee6943" width="32%"/>

#### 3. 构建和运行
- [x] 设置启动项目
- [x] 按F5或点击运行按钮
- [x] 推荐使用Windows 11

## 学习机会
本项目为WPF开发者提供了宝贵的见解：
1. **复杂UI重现**：学习重现复杂用户界面的技术
2. **自定义控件开发**：了解构建自定义WPF控件的过程
3. **MVVM实践**：在复杂应用中看到MVVM模式的实际实现
4. **Geometry Path使用**：掌握使用Geometry Path创建复杂UI设计的技巧
5. **性能优化**：学习大型WPF应用的优化策略

## 贡献
欢迎对英雄联盟客户端（WPF）项目做出贡献！随时提交问题、创建拉取请求或提出改进建议。

## 许可证
本项目采用MIT许可证 - 详情请参见[LICENSE](LICENSE)文件。

## 联系方式
- 网站：https://jamesnet.dev
- 电子邮件：james@jamesnet.dev, vickyqu115@hotmail.com

通过这个英雄联盟客户端重现项目，体验WPF在重现复杂游戏界面方面的强大功能！
