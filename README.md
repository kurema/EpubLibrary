# EpubLibrary
This repository contains:

| Title | Path | Detail |
| -- | -- | -- |
| XML Schema files | [xsd](xsd) | Converted from [epubcheck](https://github.com/w3c/epubcheck/tree/main/src/main/resources/com/adobe/epubcheck/schema) using [trang](https://relaxng.org/jclark/trang.html). |
| C# files for serialization | [CS](CS) | Generated from XML Schema files using [xsd.exe](https://docs.microsoft.com/dotnet/standard/serialization/xml-schema-definition-tool-xsd-exe). |
| GitHub Actions yamls | [.github](.github/workflows) | Instead of conversion script. |
| A dotnet library | | In the future. |

```mermaid
graph LR
  A(*.rnc/*.rng on epubcheck) -- trang --> B(xsd)
  B -- xsd.exe --> C(*.cs)
```

We got a lot of errors during the conversion but couldn't fix it.

| Stage | 3.0 | 2.0 |
| -- | -- | -- |
| Origin | 9 | 16 |
| XML Schema | 7 | 16 |
| C# | 4 | 5 |

```mermaid
pie title Survival rate (EPUB 3.0)
  "Failed on trang" : 2
  "Failed on xsd.exe" : 3
  "Successful conversion" : 4
```

```mermaid
pie title Survival rate (EPUB 2.0)
  "Failed on trang" : 0
  "Failed on xsd.exe" : 11
  "Successful conversion" : 5
```
