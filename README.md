[![](https://img.shields.io/nuget/v/soenneker.libavif.linux.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.libavif.linux/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.libavif.linux/build-and-test.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.libavif.linux/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.libavif.linux/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.libavif.linux/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.libavif.linux.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.libavif.linux/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.libavif.linux/codeql.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.libavif.linux/actions/workflows/codeql.yml)

# Soenneker.Libavif.Linux

The libavif command-line tools packaged for Linux x64 .NET applications.

## Install

```
dotnet add package Soenneker.Libavif.Linux
```

The package copies `avifenc`, `avifdec`, and `avifgainmaputil` beneath the application output directory:

```text
Resources/linux-x64/libavif/
```

Resolve that directory from `AppContext.BaseDirectory`; do not depend on the process working directory. This package contains Linux x64 binaries only and does not select a binary for other operating systems or architectures.

Most applications should reference `Soenneker.Libavif.Util`, which selects and invokes the matching platform tool. Reference this package directly when you need the native assets without the managed wrapper.

The binaries come from [AOMediaCodec/libavif](https://github.com/AOMediaCodec/libavif/releases). The upstream license and source information are included with the runtime.
