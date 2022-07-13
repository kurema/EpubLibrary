# EpubLibrary
This repository contains:

| Title | Path | Detail |
| -- | -- | -- |
| XML Schema files | [xsd](xsd) | Converted from [epubcheck](https://github.com/w3c/epubcheck/tree/main/src/main/resources/com/adobe/epubcheck/schema) using [trang](https://relaxng.org/jclark/trang.html) |
| C# files for serialization | [CS](CS) | Generated from XML Schema files using [xsd.exe](https://docs.microsoft.com/dotnet/standard/serialization/xml-schema-definition-tool-xsd-exe) |
| GitHub Actions yamls | [.github](.github/workflows) | |
| A dotnet library | | In the future. |

```mermaid
graph LR
  A(*.rnc/*.rng on epubcheck) -- trang --> B(xsd)
  B -- xsd.exe --> C(*.cs)
```

```mermaid
pie title Survival rate (EPUB 3.0)
  "Failed on trang" : 2
  "Failed on xsd.exe" : 4
  "Successful conversion" : 3
```

```mermaid
pie title Survival rate (EPUB 2.0)
  "Failed on trang" : 0
  "Failed on xsd.exe" : 11
  "Successful conversion" : 5
```
