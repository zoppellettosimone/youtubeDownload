from tkinter import *
from pytube import YouTube
from pytube import Playlist
import os
from pathlib import Path
from moviepy.editor import *


def buttonCommand():
    download()
    root.destroy()


def downloadVideos(ys):
    # Get title name of video
    titleName = ys.title.replace('.', '').replace(',', '').replace(
        ':', '').replace('?', '').replace('"', '').replace('/', '').replace("\\", '').replace(
            "~", '').replace(";", '').replace("#", '')

    # Add .mp4 to tile name
    newTitleName = titleName + ".mp4"

    print("\nDownload Audio Start")

    # Download it in Downloads\Videos
    ys.download()

    try:
        # Trasform mp4 file into mp3 file
        videoclip = VideoFileClip(newTitleName)
        audioclip = videoclip.audio
        audioclip.write_audiofile(titleName + '.mp3')
        audioclip.close()
        videoclip.close()

        # Remove .mp4 original file
        os.remove(newTitleName)

        print('\nYoutube Audio Download Complete in "Downloads\Audio"')
    except:
        print(f"\nError with {newTitleName}, check it")

def download():
    global i
    i = i + 1

    link = URL.get()

    if(i == 1):
        # Change the current directory
        cwd = os.getcwd()
        # cd ..
        os.chdir(cwd + '\..')
        # Change the current directory
        cwd = os.getcwd()
        # Check if there are folders "Download\Audio"
        listDir = os.listdir()
        thereis = False
        for j in range(0, len(listDir), 1):
            if((cwd + '\\' + listDir[j]) == (cwd + "\Downloads")):
                thereis = True
        # mkdir "Download"
        if(thereis == False):
            os.mkdir(cwd + "\Downloads")
        # cd "Download"
        os.chdir(cwd + "\Downloads")
        # Change the current directory
        cwd = os.getcwd()
        listDir = os.listdir()
        # if "Downloads" also "Audio" not exist
        if(thereis == False):
            # mkdir "Audio"
            os.mkdir(cwd + "\Audio")
        elif (thereis == True):
            #if "Downloads" exist, check if "Audio" exist or not
            thereis = False
            for j in range(0, len(listDir), 1):
                if((cwd + '\\' + listDir[j]) == (cwd + "\Audio")):
                    thereis = True
            if(thereis == False):
                os.mkdir(cwd + "\Audio")
        # cd "Audio"
        os.chdir(cwd + "\Audio")
        # Change the current directory
        cwd = os.getcwd()

    if(link.startswith("https://www.youtube.com/playlist?list=")):
        playlist = Playlist(link)
        print('\nNumber of videos in playlist: %s' % len(playlist.video_urls))
        for i in range(0, len(playlist.video_urls), 1):
            yt = YouTube(playlist.video_urls[i])
            ys = yt.streams.get_highest_resolution()
            downloadVideos(ys)
        print("Download End")

    elif(link.startswith("https://www.youtube.com/watch?v=")):
        # Get youtube videos with highest resolution
        yt = YouTube(link)
        ys = yt.streams.get_highest_resolution()
        downloadVideos(ys)
        print("Download End")

    else:
        print("Link not valid")

i = 0

# Definition for Tkinter
root = Tk()
root.geometry('380x380')
root.title("Youtube Audio Download (write by Simone Zoppelletto)")
root.configure(background='#4d0000')

# URL input (YouTube)
label_URL = Label(root, text="Link to the Youtube video",
                  background='#4d0000', foreground="white", padx=10, pady=10).pack()
URL = Entry(root, width=50)
URL.pack()

# Like Padx, Pady but between Input Label and Button Label
skipLine = Label(root, text="", background='#4d0000',
                 foreground="white").pack()

Button(root, text="Input", command=download).pack()

# Footer Credits
footer = Label(root, text="Created by Simone Zoppelletto",
               background='#4d0000', foreground="white", padx=10, pady=10).pack()

root.mainloop()
