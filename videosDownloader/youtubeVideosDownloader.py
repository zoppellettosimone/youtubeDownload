from tkinter import *
from pytube import YouTube

def buttonCommand():
    download()
    root.destroy()

def download():
    #Get youtube videos with highest resolution
    yt = YouTube(URL.get())
    ys = yt.streams.get_highest_resolution()

    print("Download Video Start")

    #Download it in Downloads\Videos
    ys.download('..\Downloads\Video')

    print('Youtube Video Download Complete in "Downloads\Video"')

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