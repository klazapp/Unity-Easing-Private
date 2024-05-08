# Easing Functions for Unity

## Introduction

The Easing package, crafted under the `com.Klazapp.Utility` namespace, provides a comprehensive suite of easing functions for Unity, facilitating the creation of smooth animations and transitions. By offering a variety of predefined easing types, this utility allows developers to easily implement sophisticated motion effects in their projects.

## Features

- **Comprehensive Easing Types:** Supports a wide range of easing functions from basic linear to complex elastic, bounce, and back types.
- **Optimized for Performance:** Methods are optimized with `MethodImpl` for aggressive inlining, ensuring high performance during runtime.
- **Ease of Use:** Simplifies the animation process in Unity by providing an enum-based approach to select and apply easing functions.

## Dependencies

- **Unity Mathematics Package:** Required for mathematical calculations involved in various easing functions.

## Compatibility

This package is universally compatible with any Unity project and is independent of rendering pipelines and specific Unity versions.

| Compatibility | URP | BRP | HDRP |
|---------------|-----|-----|------|
| Compatible    | ✔️   | ✔️   | ✔️    |

## Installation

1. Download the Easing package from the [GitHub repository](https://github.com/klazapp/Unity-Easing-Public.git) or via the Unity Package Manager.
2. Include the script in your Unity project to utilize the easing functions in your animations.

## Usage

To apply an easing function, reference the `Easing` class and use the `SetEasingByEaseType` method with the desired `EaseType`. Here is an example of how to use it in your code:

```csharp
float easedValue = Easing.SetEasingByEaseType(EaseType.InOutQuad, timeValue);
```

## To-Do List (Future Features)

- [ ] Addition of visual editor tools to preview easing curves.
- [ ] Expand the library to include more exotic easing functions.
- [ ] Create Unity animations directly using these easing functions without writing code.

## License

This utility is released under the MIT License, permitting free use, modification, and distribution within your projects.

---

Please review and let me know if there's anything else you need!
