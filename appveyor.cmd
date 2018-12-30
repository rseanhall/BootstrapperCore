@setlocal
@pushd %~dp0

nuget restore

msbuild -p:Configuration=Release

msbuild -t:Pack -p:Configuration=Release src\WixToolset.BootstrapperCore\WixToolset.BootstrapperCore.csproj

@popd
@endlocal