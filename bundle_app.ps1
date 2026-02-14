
# 1. Clean and Build the project
Write-Host "Building project..." -ForegroundColor Cyan
dotnet build -c Release

# 2. Define source and destination
$SourceDir = "bin\Release\net472"
if (-not (Test-Path $SourceDir)) {
    $SourceDir = "bin\Debug\net472"
}
$BundleName = "FixedCompta.zip"
$TempDir = "BundleTemp"

Write-Host "Collecting files from $SourceDir..." -ForegroundColor Cyan

# 3. Create a clean temp directory for bundling
if (Test-Path $TempDir) { Remove-Item $TempDir -Recurse -Force }
New-Item -ItemType Directory -Path $TempDir | Out-Null

# 4. Copy everything from build output to temp dir
Copy-Item -Path "$SourceDir\*" -Destination $TempDir -Recurse -Force

# 5. Remove unnecessary development files
$ExcludeFiles = @("*.pdb", "*.xml", "*.deps.json")
foreach ($pattern in $ExcludeFiles) {
    Remove-Item -Path "$TempDir\$pattern" -ErrorAction SilentlyContinue
}

# 6. Create the ZIP file
if (Test-Path $BundleName) { Remove-Item $BundleName }
Write-Host "Creating $BundleName..." -ForegroundColor Green

Add-Type -AssemblyName "System.IO.Compression.FileSystem"
$destPath = [System.IO.Path]::GetFullPath($BundleName)
$srcPath = [System.IO.Path]::GetFullPath($TempDir)
[System.IO.Compression.ZipFile]::CreateFromDirectory($srcPath, $destPath)

# 7. Cleanup
Remove-Item $TempDir -Recurse -Force

Write-Host "Done! Your deployment bundle is ready at: $BundleName" -ForegroundColor Yellow
