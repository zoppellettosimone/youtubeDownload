from tkinter import *
from pytube import YouTube
from pytube import Playlist

def downloadVideos(ys):
        print("Download Video Start")

        #Download it in Downloads\Videos
        ys.download("..\Downloads\Videos")
        
        print("Download Video Finish")

def download():
    link = URL.get()
    if(link.startswith("https://www.youtube.com/playlist?list=")):
        playlist = Playlist(link)
        print('Number of videos in playlist: %s' % len(playlist.video_urls))
        for video_url in playlist.video_urls:
            yt = YouTube(video_url)
            ys = yt.streams.get_highest_resolution()
            downloadVideos(ys)

    elif(link.startswith("https://www.youtube.com/watch?v=")):
        #Get youtube videos with highest resolution
        yt = YouTube(link)
        ys = yt.streams.get_lowest_resolution()
        downloadVideos(ys)

#Definition for Tkinter
root = Tk()
root.geometry('380x380')
root.title("Youtube Videos Download (write by Simone Zoppelletto)")
root.configure(background='#4d0000')

#URL input (YouTube)
label_URL = Label(root, text="Link to the Youtube video", background='#4d0000', foreground="white", padx=10, pady=10).pack()
URL = Entry(root, width = 50)
URL.pack()

#Like Padx, Pady but between Input Label and Button Label
skipLine = Label(root, text="", background='#4d0000', foreground="white").pack()

Button(root, text="Input", command=download).pack()

#Footer Credits
footer = Label(root, text="Created by Simone Zoppelletto", background='#4d0000', foreground="white", padx=10, pady=10).pack()

root.mainloop()
