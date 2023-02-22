<img src="https://raw.githubusercontent.com/steamhappy/youtube-dl-GUI/master/youtube-dl%20GUI/Resources/final128.png" alt="logo" align="left" height="100"/>

# youtube-dl-GUI <br> ![version badge](https://img.shields.io/github/v/release/steamhappy/youtube-dl-GUI?label=latest-release) ![downloads](https://img.shields.io/github/downloads/steamhappy/youtube-dl-GUI/total)

A basic and easy to use GUI for [youtube-dl](https://github.com/ytdl-org/youtube-dl) and youtube-dl forks designed for Windows

### Features

- Download videos from [all sites supported by youtube-dl](https://github.com/ytdl-org/youtube-dl/blob/master/docs/supportedsites.md)
- Automatically keeps [yt-dlp](https://github.com/yt-dlp/yt-dlp) updated, update support for other forks can be [requested!](https://github.com/steamhappy/youtube-dl-GUI/issues)
- Downloads can be cancelled without exiting GUI
- Download progress can be seen real-time
- Video download directory is remembered for future launches

# How to use

1. Download a Windows version of [youtube-dl](https://github.com/ytdl-org/youtube-dl/releases) or your favourite youtube-dl fork such as [yt-dlp](https://github.com/yt-dlp/yt-dlp/releases), refer to [Change Executable](https://github.com/steamhappy/youtube-dl-GUI#change-executable) if not using youtube-dl or using youtube-dl that is in a different folder than the GUI.
2. Download a version of [youtube-dl-GUI](https://github.com/steamhappy/youtube-dl-GUI/releases)
3. Open youtube-dl-GUI.exe, select a download folder, paste a video link from [any youtube-dl supported site](https://github.com/ytdl-org/youtube-dl/blob/master/docs/supportedsites.md) and click 'Download'. Downloaded video will appear in your chosen folder. Executable and download folder will now be saved for future uses.

# Dependencies

If planning to use [youtube-dl](https://github.com/ytdl-org/youtube-dl/releases), the [Microsoft Visual C++ 2010 Service Pack 1 Redistributable Package (x86)](https://download.microsoft.com/download/1/6/5/165255E7-1014-4D0A-B094-B6A430A6BFFC/vcredist_x86.exe) must be installed, it is likely that it is already installed on your computer. 

### Not required but recommended

- [**ffmpeg** and **ffprobe**](https://github.com/yt-dlp/yt-dlp#strongly-recommended)

# Enable cookies

To download age-restricted YouTube videos, cookies have to be extracted from your browser that is signed into YouTube and passed to youtube-dl, [follow youtube-dl's instructions on how to do this.](https://github.com/ytdl-org/youtube-dl#how-do-i-pass-cookies-to-youtube-dl)

# Pass advanced options to youtube-dl

Additional options can be passed to [youtube-dl](https://github.com/ytdl-org/youtube-dl#options) and [yt-dlp](https://github.com/yt-dlp/yt-dlp#usage-and-options) by adding them in the same field as the video link either before or after the video link just like the example below.

<img src="https://raw.githubusercontent.com/steamhappy/youtube-dl-GUI/master/Advanced%20options%20example.png"/>

# Change Executable

By default [youtube-dl](https://github.com/ytdl-org/youtube-dl) is the executable ran by youtube-dl-GUI but any youtube-dl fork should work, however only [yt-dlp](https://github.com/yt-dlp/yt-dlp/releases) has been tested. Changing the executable can be done by clicking the button dedicated to it in the GUI and selecting your desired fork's exe file, this will now be saved for the next time youtube-dl-GUI is launched. This process also has to be done if you are using youtube-dl but it is stored in a different folder than the GUI is.

# Missing MSVCR100.dll error

[youtube-dl](https://github.com/ytdl-org/youtube-dl) requires the [Microsoft Visual C++ 2010 Service Pack 1 Redistributable Package (x86)](https://download.microsoft.com/download/1/6/5/165255E7-1014-4D0A-B094-B6A430A6BFFC/vcredist_x86.exe) to be installed. [yt-dlp](https://github.com/yt-dlp/yt-dlp) does not require it to be installed.
