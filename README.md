[![](https://img.shields.io/nuget/v/soenneker.libavif.linux.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.libavif.linux/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.libavif.linux/build-and-test.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.libavif.linux/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.libavif.linux.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.libavif.linux/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.libavif.linux/codeql.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.libavif.linux/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Libavif.Linux
### A bundled libavif command-line distribution for Linux x64 .NET applications.

## Installation

```
dotnet add package Soenneker.Libavif.Linux
```

The package copies the official statically linked `avifenc`, `avifdec`, and `avifgainmaputil` release tools to `Resources/linux-x64/libavif`.

The binaries come from [AOMediaCodec/libavif](https://github.com/AOMediaCodec/libavif/releases). The upstream license and source information are included with the runtime.
