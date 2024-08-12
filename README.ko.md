# 리그 오브 레전드 클라이언트 (WPF) [![English](https://img.shields.io/badge/docs-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/docs-中文-red.svg)](README.zh-CN.md) [![한국어](https://img.shields.io/badge/docs-한국어-green.svg)](README.ko.md) 

WPF를 사용한 리그 오브 레전드 클라이언트의 고품질 재현, 고급 WPF 기술과 Jamesnet.Wpf의 강력함을 보여주는 프로젝트

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnet214/leagueoflegends.svg)](https://github.com/jamesnet214/leagueoflegends/stargazers)
[![Forks](https://img.shields.io/github/forks/jamesnet214/leagueoflegends.svg)](https://github.com/jamesnet214/leagueoflegends/network/members)
[![Issues](https://img.shields.io/github/issues/jamesnet214/leagueoflegends.svg)](https://github.com/jamesnet214/leagueoflegends/issues)

## 프로젝트 개요

이 프로젝트는 WPF 기술을 사용하여 리그 오브 레전드 클라이언트 인터페이스를 충실히 재현한 것입니다. 현대적인 게임 클라이언트와 동일한 복잡하고 고성능의 사용자 인터페이스를 만드는 데 있어 WPF와 Jamesnet.Wpf 프레임워크의 능력을 보여줍니다.

<img src="https://github.com/user-attachments/assets/9aa294d7-be6d-48ac-8d81-8d8eeb2d79dd" width="49%"/>
<img src="https://github.com/user-attachments/assets/ecb3f8e5-829f-4c44-ad1e-db4f61aeed19" width="49%"/>
<img src="https://github.com/user-attachments/assets/0ec377bc-3242-4dbb-9e8e-d763ca8984e5" width="49%"/>  
<img src="https://github.com/user-attachments/assets/f7313f69-9255-4509-ba8c-2c1d9bdbc80e" width="49%"/>  
<img src="https://github.com/user-attachments/assets/2afe65fe-5189-403b-b042-f184f974bbcf" width="49%"/>  
<img src="https://github.com/user-attachments/assets/57c4f317-68c0-46fa-9e76-b46aeab617d0" width="49%"/>  
<img src="https://github.com/user-attachments/assets/1db54994-a3bc-469e-9ca8-b537473f3773" width="49%"/> 
<img src="https://github.com/user-attachments/assets/dc8159c1-dbdd-43ad-865e-6a593882a3b9" width="49%"/> 

## 주요 기능 및 구현 사항
#### 1. 고급 WPF 기술
- [x] 향상된 WPF 개발을 위한 Jamesnet.Wpf 활용
- [x] 유연하고 유지보수가 용이한 코드를 위한 의존성 주입 구현
- [x] 향상된 확장성을 위한 프로젝트 모듈화 및 분산화

#### 2. MVVM 아키텍처
- [x] 코드 생성 및 MVVM 패턴 구현을 위한 CommunityToolkit.Mvvm 사용
- [x] View와 ViewModel 사이의 명확한 관심사 분리

#### 3. 커스텀 컨트롤
- [x] 리그 오브 레전드 UI 컴포넌트와 일치하는 커스텀 WPF 컨트롤 개발
- [x] 고유한 시각적 디자인을 위한 ControlTemplate의 광범위한 사용

#### 4. 복잡한 UI 디자인
- [x] Geometry Path를 사용한 정교한 디자인 요소 구현
- [x] 리그 오브 레전드 클라이언트 인터페이스의 픽셀 퍼펙트 재현

#### 5. 성능 최적화
- [x] 부드러운 UI 상호작용을 위한 효율적인 렌더링 및 리소스 관리
- [x] 최적화된 데이터 바인딩 및 UI 가상화 기술

## 기술 스택
- .NET 8.0
- WPF (Windows Presentation Foundation)
- Jamesnet.Wpf
- CommunityToolkit.Mvvm

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
