from tkinter import *
from pytube import YouTube
from pytube import Playlist
import os
from pathlib import Path
from moviepy.editor import *


def buttonCommand():
    download()
    root.destroy()

def download():
    print('Start Conversion')

    # Trasform mp4 file into mp3 file
    videoclip = VideoFileClip(name.get() + '.mp4')
    audioclip = videoclip.audio
    audioclip.write_audiofile(name.get() + '.mp3')
    audioclip.close()
    videoclip.close()

    # Remove .mp4 original file
    os.remove(name.get() + '.mp4')

    print('End Conversion')

# Definition for Tkinter
root = Tk()
root.geometry('380x380')
root.title("Mp4 to Mp3 Converter (write by Simone Zoppelletto)")
root.configure(background='#4d0000')

# URL input (YouTube)
nameMp4 = Label(root, text="File.Mp4 Name (Without .mp4)",
                  background='#4d0000', foreground="white", padx=10, pady=10).pack()
name = Entry(root, width=50)
name.pack()

# Like Padx, Pady but between Input Label and Button Label
skipLine = Label(root, text="", background='#4d0000',
                 foreground="white").pack()

Button(root, text="Input", command=download).pack()

# Footer Credits
footer = Label(root, text="Created by Simone Zoppelletto",
               background='#4d0000', foreground="white", padx=10, pady=10).pack()

root.mainloop()
