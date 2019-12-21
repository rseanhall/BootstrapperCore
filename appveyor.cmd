@setlocal
@pushd %~dp0

nuget restore -SolutionDirectory . src\burn\WixToolset.BootstrapperCore.Native.proj

msbuild src\burn\WixToolset.BootstrapperCore.Native.proj

@popd
@endlocal