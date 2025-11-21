$ServerPath = "\\Win-3dma5kl5ghd\c$\Users\windev\Development\Jelly\Payload_Type\Jelly\agent_code\Jelly\bin\Debug\";
$ClientPath = "\\COMPUTER01\c$\Users\windev\Development\Jelly\Payload_Type\Jelly\agent_code\Jelly\bin\Debug\";
$WorkstationPath = "\\WORKSTATION01\c$\Users\windev\Development\Jelly\Payload_Type\Jelly\agent_code\Jelly\bin\Debug\";
$localpath  = "C:\Users\windev\Development\Jelly\Payload_Type\Jelly\agent_code\Jelly\bin\Debug\"


Get-ChildItem $localpath | % {
    $name = $_.FullName;
    Copy-Item -Force $_.FullName $ServerPath
    if ($?)
    {
        Write-Host "[+] Copied $name to Domain Controller.";
    } else {
        Write-Host "[-] Failed to write $name to Domain Controller.";
    }

    Copy-Item -Force $_.FullName $ClientPath
    if ($?)
    {
        Write-Host "[+] Copied $name to Server 2012.";
    } else {
        Write-Host "[-] Failed to write $name to Server 2012.";
    }

    Copy-Item -Force $_.FullName $WorkstationPath
    if ($?)
    {
        Write-Host "[+] Copied $name to Windows 10.";
    } else {
        Write-Host "[-] Failed to write $name to Windows 10.";
    }
}