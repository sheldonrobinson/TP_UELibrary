This template delivers a complete, production‑ready implementation of **Unreal Engine as a Shared Library (UELibrary)**, enabling developers to embed an Unreal Engine game inside an external Win32 application. Built on top of Epic’s official UELibrary workflow (UE 4.27+), it fills in the missing steps, fixes common issues, and provides a fully functional example that compiles and runs out of the box.

Whether you’re building custom tools, hybrid UI/3D applications, enterprise visualization systems, or modular game architectures, this template gives you everything needed to integrate Unreal Engine cleanly and reliably into your own host application.

## **What This Template Provides**
- **A fully configured Unreal C++ project** built as a monolithic DLL with `UE_LIBRARY_ENABLED` and `bShouldCompileAsDLL = true`.
- **A working Win32 host application** that loads the Unreal DLL, initializes the engine, forwards window messages, and manages the full engine lifecycle.
- **Extended UELibrary API examples**, showing how to export your own functions using `__declspec(dllexport)` to expose gameplay logic or engine data to external applications.
- **Practical fixes and improvements** not covered in Epic’s documentation, including input handling corrections and editor module version fixes.
- **Clean, minimal integration code** demonstrating how to embed Unreal rendering inside a native window with full control over startup, shutdown, and message routing.

## **Key Features**
- Complete UELibrary setup with all required engine and project configuration  
- Game project compiled as a DLL with proper export macros  
- Host application demonstrating dynamic loading and message forwarding  
- Custom API extension examples for exposing gameplay logic  
- Build scripts and configuration files included  
- Compatible with UE 5.x source builds  

## **Ideal For**
- Developers embedding Unreal Engine into proprietary tools or editors  
- Teams building simulation, visualization, or enterprise applications  
- Projects requiring Unreal to run inside an existing UI framework  
- Modular game systems where the engine loads dynamically  
- Anyone who wants a working, reference‑quality UELibrary implementation  

## **Why This Template Matters**
Epic’s documentation introduces the concept of Unreal Engine as a library, but several critical steps are missing or unclear. This template provides a complete, working solution that eliminates guesswork and dramatically reduces setup time. It’s a practical, real‑world example of embedding Unreal Engine into external applications—ready to build, extend, and ship.
