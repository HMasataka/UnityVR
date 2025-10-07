# UnityVR

Unity VRテンプレートベースのVRプロジェクトです。

## 主な機能

### XRインタラクション機能

- **XRKnob** - VRでの回転ノブ操作 (`Assets/VRTemplateAssets/Scripts/XRKnob.cs`)
- **LaunchProjectile** - プロジェクタイル発射システム (`Assets/VRTemplateAssets/Scripts/LaunchProjectile.cs`)
- **XRPokeFollowAffordance** - ポケインタラクション用アフォーダンス効果 (`Assets/VRTemplateAssets/Scripts/XRPokeFollowAffordanceFill.cs`)

### VRハンドトラッキング

- **HandVisualizer** - 手の可視化システム (`Assets/Samples/XR Hands/1.6.1/HandVisualizer/Scripts/HandVisualizer.cs`)
- **PokeGestureDetector** - ポケジェスチャー検出 (`Assets/Samples/XR Interaction Toolkit/3.2.1/Hands Interaction Demo/Scripts/PokeGestureDetector.cs`)
- **MetaSystemGestureDetector** - Metaシステムジェスチャー検出 (`Assets/Samples/XR Interaction Toolkit/3.2.1/Hands Interaction Demo/Scripts/MetaSystemGestureDetector.cs`)

### UI・インタラクション

- **Callout** - VR空間でのコールアウト表示 (`Assets/VRTemplateAssets/Scripts/Callout.cs`)
- **StepManager** - チュートリアルステップ管理 (`Assets/VRTemplateAssets/Scripts/StepManager.cs`)
- **BooleanToggleVisualsController** - ブール値切り替えUI制御 (`Assets/VRTemplateAssets/Scripts/BooleanToggleVisualsController.cs`)

### 移動・テレポート

- **DynamicMoveProvider** - 動的移動プロバイダー (`Assets/Samples/XR Interaction Toolkit/3.2.1/Starter Assets/Scripts/DynamicMoveProvider.cs`)
- **ClimbTeleportDestinationIndicator** - クライム・テレポート先インジケーター (`Assets/Samples/XR Interaction Toolkit/3.2.1/Starter Assets/Scripts/ClimbTeleportDestinationIndicator.cs`)

### その他のユーティリティ

- **Rotator** - オブジェクト回転機能 (`Assets/VRTemplateAssets/Scripts/Rotator.cs`)
- **VideoPlayerRenderTexture** - ビデオプレイヤー制御 (`Assets/VRTemplateAssets/Scripts/VideoPlayerRenderTexture.cs`)
- **HandSubsystemManager** - 手のサブシステム管理 (`Assets/VRTemplateAssets/Scripts/HandSubsystemManager.cs`)

## 使用技術・パッケージ

- Unity XR Interaction Toolkit 3.2.1
- Unity XR Hands 1.6.1
- Unity XR Management 4.5.1
- Unity XR OpenXR 1.15.1
- Unity AR Foundation 6.2.0
- Universal Render Pipeline (URP) 17.2.0

## シーン構成

- `BasicScene.unity` - 基本VRシーン
- `SampleScene.unity` - サンプルシーン
