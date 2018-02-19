# PixelateVideo

Pixelate videos with the power of Pixelator and FFMPEG

## Set up

### Pixelator

If you need Pixelator, get it [here](http://pixelatorapp.com/index.html).

**When providing the path to Pixelator, provide a path to _pixelator_cmd.exe, not Pixelator.exe**

### FFMPEG

This project relies on FFMPEG to work it's magic. The program will not launch without it.

Download FFMPEG from [this page](https://ffmpeg.zeranoe.com/builds/). The program was built with version 20180219-56f77b0 (Windows 64-bit, Static).

Once downloaded, copy `ffmpeg.exe` from the `bin` folder to the folder containing `PixelateVideo.exe` (if you cloned the repo, that's `PixelateVideo/bin/Release`)

### Actually using PixelateVideo

Follow the prompts next to the textboxes to fill in the correct information.

In most cases, you can just leave the frames set to "all".

Pixelator arguments are provided at the bottom of the window in Pixelator.

**The output file path should end with a backslash (e.g.: "C:\my\output\path\")**

**When providing Pixelator arguments, only input from the first command with "--" in front of it to the end!**