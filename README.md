<img src="https://raw.githubusercontent.com/KDunny/youtube-dl-GUI/master/youtube-dl%20GUI/Resources/final128.png" alt="logo" align="left" height="100"/>

# youtube-dl-GUI <br> ![version badge](https://img.shields.io/github/v/release/KDunny/youtube-dl-GUI?label=latest-release) ![downloads](https://img.shields.io/github/downloads/KDunny/youtube-dl-GUI/total)

A basic and easy to use GUI for youtube-dl designed for Windows

### Features
- Download videos from [all sites supported by youtube-dl](https://github.com/ytdl-org/youtube-dl/blob/master/docs/supportedsites.md)
- Automatically keeps [yt-dlp](https://github.com/yt-dlp/yt-dlp) updated, update support for other forks can be [requested!](https://github.com/KDunny/youtube-dl-GUI/issues)
- Downloads can be cancelled without exiting GUI
- Download progress can be seen real-time
- Video download directory is remembered for future launches

# How to use
1. Download a Windows version of [youtube-dl](https://github.com/ytdl-org/youtube-dl/releases) or your favourite youtube-dl fork such as [yt-dlp](https://github.com/yt-dlp/yt-dlp/releases), refer to [Change Executable](https://github.com/KDunny/youtube-dl-GUI/edit/master/README.md#change-executable) if not using youtube-dl
2. Download a version of [youtube-dl-GUI](https://github.com/KDunny/youtube-dl-GUI/releases)
3. Store all downloaded .exe files in the same folder
4. Open youtube-dl-GUI.exe, select a download folder, paste a video link from [any youtube-dl supported site](https://github.com/ytdl-org/youtube-dl/blob/master/docs/supportedsites.md) and click 'Download'. Downloaded video will appear in your chosen folder. Executable and download folder will now be saved for future uses.

# Enable cookies

To download age-restricted YouTube videos, cookies have to be extracted from your browser that is signed into YouTube and passed to youtube-dl, [follow youtube-dl's instructions on how to do this](https://github.com/ytdl-org/youtube-dl#how-do-i-pass-cookies-to-youtube-dl) and ensure that you save the cookies file in the same folder as youtube-dl-GUI and name it 'youtube.com_cookies.txt'

# Pass advanced options to youtube-dl

Additional options can be passed to [youtube-dl](https://github.com/ytdl-org/youtube-dl#options) and [yt-dlp](https://github.com/yt-dlp/yt-dlp#usage-and-options) by adding them in the same field as the video link either before or after the video link just like the example below

<img src="https://raw.githubusercontent.com/KDunny/youtube-dl-GUI/master/Advanced%20options%20example.png"/>

# Change Executable

By default youtube-dl is the executable ran by youtube-dl-GUI but as long as the executable is in the same folder as youtube-dl-GUI then any youtube-DL fork should work, however only [yt-dlp](https://github.com/yt-dlp/yt-dlp/releases) has been tested. Enter only the file name including .exe into the text field and upon clicking 'Save', this will now be saved for the next time youtube-dl-GUI is launched.

<img src="https://raw.githubusercontent.com/KDunny/youtube-dl-GUI/master/Change%20executable%20example.png"/>
