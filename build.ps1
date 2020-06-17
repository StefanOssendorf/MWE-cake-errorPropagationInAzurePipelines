& dotnet tool restore
#& dotnet cake ./build.cake --bootstrap
if ($LASTEXITCODE -eq 0)
{
    & dotnet cake build.cake $args
}

exit $LASTEXITCODE