# 리그 오브 레전드 클라이언트 (WPF)

[![English](https://img.shields.io/badge/docs-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/docs-中文-red.svg)](README.zh-CN.md) [![한국어](https://img.shields.io/badge/docs-한국어-green.svg)](README.ko.md)

WPF를 활용한 리그 오브 레전드 클라이언트의 고품질 재현 프로젝트입니다. 이 프로젝트는 WPF의 다양한 기술 구현에 대한 사례들을 포함하고 있으며, 대규모 프로젝트의 분산화 설계에 관한 폭넓은 기술적 접근을 보여줍니다.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnetgroup/leagueoflegends-wpf.svg)](https://github.com/jamesnetgroup/leagueoflegends-wpf/stargazers)
[![Forks](https://img.shields.io/github/forks/jamesnetgroup/leagueoflegends-wpf.svg)](https://github.com/jamesnetgroup/leagueoflegends-wpf/network/members)
[![Issues](https://img.shields.io/github/issues/jamesnetgroup/leagueoflegends-wpf.svg)](https://github.com/jamesnetgroup/leagueoflegends-wpf/issues)

#### 리그오브레전드 XAML-Based 시리즈:
[리그 오브 레전드 클라이언트 (WPF)](https://github.com/jamesnetgroup/leagueoflegends-wpf)  
[리그 오브 레전드 클라이언트 (Uno-Platform)](https://github.com/jamesnetgroup/leagueoflegends-uno)

## 프로젝트 소개

저희는 2008년부터 WPF 기술을 연구하고 경험을 쌓아왔습니다. 그동안 Xamarin, MAUI, Uno-Platform, AvaloniaUI, OpenSilver 등 다양한 XAML 기반의 크로스 플랫폼 기술이 발전해 왔고, 이를 통해 WPF에서 축적한 기술을 크로스 플랫폼으로 확장할 수 있는 가능성이 열렸습니다.

이번에 공개하는 리그 오브 레전드 WPF 버전은 XAML 기반의 풍부한 UX, C#의 객체지향적 설계, 그리고 체계적인 프로젝트 구조를 바탕으로 만들어졌습니다. 이는 WPF의 강력한 기능을 최대한 활용하면서도, 향후 다른 XAML 기반 플랫폼으로의 확장 가능성을 고려한 프로젝트입니다.

이 프로젝트는 WPF에서 대규모 프로젝트를 구현하는 방법을 보여줍니다. 복잡한 컨트롤들을 CustomControl로 구현하여, 개발자들에게 풍부한 학습 자료를 제공하고자 합니다. 또한, WPF의 다양한 기술 구현 사례를 포함하고 있어, WPF의 강력한 기능들을 실제 프로젝트에서 어떻게 활용할 수 있는지 보여줍니다.

특히 이 프로젝트는 대규모 애플리케이션의 분산화 설계에 대한 폭넓은 접근 방식을 제시합니다. 모듈화된 구조, 효율적인 상태 관리, 그리고 확장 가능한 아키텍처를 통해 복잡한 애플리케이션을 어떻게 구조화하고 관리할 수 있는지 보여줍니다.

Jamesnet.Core 프레임워크 라이브러리는 WPF와 Uno에서 동일하게 동작하도록 .NET Standard 2.0 기반으로 설계되었습니다. 이 라이브러리는 WPF에서는 Jamesnet.Window로, Uno-Platform에서는 Jamesnet.Uno로 제공됩니다.

이 프로젝트에서는 Jamesnet.Core와 Jamesnet.Window의 실제 소스 코드를 직접 참조하고 있어, XAML 기반 프레임워크의 설계 방식도 함께 학습할 수 있습니다.

우리는 이 프로젝트를 통해 WPF의 강력한 기능을 선보이는 동시에, 향후 Uno-Platform, MAUI, AvaloniaUI, OpenSilver, WinUI3 같은 다양한 XAML 기반 플랫폼으로의 확장 가능성을 제시하고, 크로스 플랫폼 개발의 새로운 지평을 열고자 합니다.


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

## 핵심 기술 스택
> 레포지터리 안에 프레임워크 소스코드가 모두 포함되어 있습니다.

  - [x] **Jamesnet.Core**: .NET Standard 2.0 기반의 크로스 플랫폼 코어 라이브러리
  - [x] **Jamesnet.Windoww**: WPF에 최적화된 윈도우 관리 및 UI 프레임워크

이 두 라이브러리는 WPF와 Uno-Platform 모두에서 동일하게 사용 가능하며, 대규모 프로젝트의 아키텍처 설계에 필요한 모든 핵심 기능을 포함하고 있습니다.

## 주요 기능 및 구현 사항

1. **대규모 프로젝트 아키텍처**
  - [x] 모듈화 및 분산 시스템 설계
  - [x] 의존성 주입을 통한 느슨한 결합
  - [x] 플러그인 기반 확장 가능한 구조

3. **고급 WPF 기술**
  - [x] 다양한 CustomControl 구현
  - [x] VisualStateManager를 활용한 복잡한 상태 관리
  - [x] 데이터 가상화 및 UI 가상화 기술

5. **성능 최적화**
  - [x] 효율적인 리소스 관리 및 메모리 사용
  - [x] 비동기 프로그래밍 패턴 적용
  - [x] 렌더링 최적화 기법

6. **UI/UX 디자인**
  - [x] Geometry Path를 활용한 복잡한 그래픽 구현
  - [x] 사용자 정의 애니메이션 및 전환 효과
  - [x] 동적 테마 시스템

7. **프레임워크 설계**
- [x] 이벤트 기반 통신 시스템
- [x] 상태 관리 패턴 구현
- [x] 확장 가능한 네비게이션 시스템

이 프로젝트는 WPF의 강력한 기능을 최대한 활용하면서, Jamesnet.Core와 Jamesnet.Window를 기반으로 한 고급 설계 패턴과 기술들을 포괄적으로 보여줍니다. 대규모 애플리케이션 개발에 필요한 다양한 기술과 패턴들이 실제 적용된 사례를 제공하여, WPF 개발자들에게 풍부한 학습 자료가 될 것입니다.

우리는 이 프로젝트가 WPF 개발자들에게 영감을 주고, 대규모 데스크톱 애플리케이션 개발의 모범 사례로 활용되기를 바랍니다. 또한, 이 프로젝트를 통해 WPF와 Uno-Platform 간의 코드 공유 전략과 크로스 플랫폼 개발의 새로운 가능성을 탐구할 수 있기를 기대합니다.

> 향후 MAUI, WinUI 3, AvaloniaUI, OpenSilver와 같은 새로운 플랫폼 버전도 계획 중입니다.

## 기술 스택
- .NET 8.0
- WPF (Windows Presentation Foundation)
- Jamesnet.Core (.NET Standard 2.0)
- Jamesnet.Windows
- Jamesnet.Uno

## 시작하기
### 필요 조건
- Visual Studio 2022 이상
- .NET 8.0 SDK
- Jamesnet.Wpf NuGet 패키지

### 설치 및 실행
#### 1. 리포지토리 클론:

```
git clone https://github.com/jamesnet214/leagueoflegends.git
```

#### 2. 솔루션 열기
- [x] Visual Studio
- [x] Visual Studio Code
- [x] JetBrains Rider

<img src="https://github.com/user-attachments/assets/af70f422-7057-4e77-a54d-042ee8358d2a" width="32%"/>
<img src="https://github.com/user-attachments/assets/e4feaa10-a107-4b58-8d13-1d8be620ec62" width="32%"/>
<img src="https://github.com/user-attachments/assets/5ff487f6-55e4-43e1-9abf-f8d419ee6943" width="32%"/>

#### 3. 빌드 및 실행
- [x] 시작 프로젝트 설정
- [x] F5를 누르거나 실행 버튼 클릭
- [x] Windows 11 권장

## 학습 기회
이 프로젝트는 WPF 개발자들에게 귀중한 통찰력을 제공합니다:
1. **복잡한 UI 재현**: 정교한 사용자 인터페이스를 재현하는 기술 학습
2. **커스텀 컨트롤 개발**: WPF 커스텀 컨트롤 구축 과정 이해
3. **실전 MVVM**: 복잡한 애플리케이션에서 MVVM 패턴의 실제 구현 사례 확인
4. **Geometry Path 사용**: 정교한 UI 디자인을 위한 Geometry Path 사용 마스터
5. **성능 최적화**: 대규모 WPF 애플리케이션 최적화 전략 학습

## 기여하기
리그 오브 레전드 클라이언트 (WPF) 프로젝트에 대한 기여를 환영합니다! 이슈를 제출하거나, 풀 리퀘스트를 생성하거나, 개선 사항을 제안해 주세요.

## 라이선스
이 프로젝트는 MIT 라이선스 하에 배포됩니다. 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

## 연락처
- 웹사이트: https://jamesnet.dev
- 이메일: james@jamesnet.dev, vickyqu115@hotmail.com

이 리그 오브 레전드 클라이언트 재현을 통해 복잡한 게임 인터페이스를 재현하는 WPF의 힘을 경험해보세요!
