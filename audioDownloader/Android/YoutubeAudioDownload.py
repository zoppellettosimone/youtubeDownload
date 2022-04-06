from kivy.app import App
from kivy.uix.gridlayout import GridLayout
from kivy.core.window import Window
from kivy.uix.image import Image
from kivy.uix.label import Label
from kivy.uix.button import Button
from kivy.uix.textinput import TextInput

from pytube import YouTube
from pytube import Playlist
import os
from moviepy.editor import *

class YoutubeAudioDownloadApp(App):
    def build(self):
        self.window = GridLayout()
        self.window.cols = 1
        self.window.size_hint = (0.8, 0.9)
        self.window.pos_hint = {"center_x": 0.5, "center_y": 0.5}
        Window.clearcolor = (64/255.0, 64/255.0, 64/255.0, 1)
        Window.size = (360, 640)
        #self.window.add_widget()

        #Logo Image
        self.window.add_widget(Image(
            source="logo.png",
            size_hint=(1, 0.4)
            ))

        #Text Box Input
        self.linkTextInput = TextInput(
            size_hint=(1, 0.24),
            font_size='20sp',
            padding_y='12sp'
        )
        self.window.add_widget(self.linkTextInput)

        #Button
        self.downloadButton = Button(
            text="Download",
            size_hint=(1, 0.2),
            bold = True,
            background_color='#0099ff'
            )
        self.window.add_widget(self.downloadButton)
        self.downloadButton.bind(on_press = self.download)

        #InfoLabel
        self.messageLabel = Label(
            text="Hi",
            font_size='20sp',
            color = '#ffffff'
            )
        self.window.add_widget(self.messageLabel)

        #Footer Label
        self.footerLabel = Label(
            text="Created By Simone Zoppelletto\nTrial version",
            font_size='20sp',
            color = '#ffffff'
            )
        self.window.add_widget(self.footerLabel)

        return self.window

    def download(self, instance):

        def downloadVideos(ys):

            print("Inizio Download")
            # Get title name of video
            titleName = ys.title.replace('.', '').replace(',', '').replace(
                ':', '').replace('?', '').replace('"', '').replace('/', '').replace("\\", '').replace(
                    "~", '').replace(";", '').replace("#", '')

            # Add .mp4 to tile name
            newTitleName = titleName + ".mp4"

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

        global i
        i = i + 1

        if(i == 1):
            link = self.linkTextInput.text

            # Change the current directory
            cwd = os.getcwd()
            print(cwd)
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
                self.messageLabel.text = f"Download Start"
                playlist = Playlist(link)
                for i in range(0, len(playlist.video_urls), 1):
                    yt = YouTube(playlist.video_urls[i])
                    ys = yt.streams.get_highest_resolution()
                    downloadVideos(ys)
                self.messageLabel.text = f"Download End"

            elif(link.startswith("https://www.youtube.com/watch?v=")):
                self.messageLabel.text = f"Download Start"
                # Get youtube videos with highest resolution
                yt = YouTube(link)
                ys = yt.streams.get_highest_resolution()
                downloadVideos(ys)
                self.messageLabel.text = f"Download End"

            else:
                self.messageLabel.text = f"Link not valid"

            #Quando finisce
            i=0

    


i = 0
YoutubeAudioDownloadApp().run()