# AutoRest Repro

This code reproduces an issue where the `[CodeGenSuppressType]` appears to be ignored.

## Steps

- Ensure [autorest is installed](https://github.com/Azure/autorest/blob/main/docs/install/readme.md).
- Clone this repro
- Execute [MathClient/generate.ps1](./MathClient/generate.ps1)
- Note that [MathClient/Generated/AddRequest.cs](./MathClient/Generated/AddRequest.cs) is generated even though `[assembly: CodeGenSuppressType("AddRequest")]` declared in [MathClient/Customized/AssemblyAttributes.cs](./MathClient/Customized/AssemblyAttributes.cs)

## Expected behavior
- `AddRequest` isn't generated.