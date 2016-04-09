#hashtag_maze

#Maze Table of Contents
Elevator Pitch
Project Stack
Structures and Design

Elevator Pitch
#Maze is a web application that builds an interactive visualization of a Twitter topic. It uses Twitter Rest API, Unity, and the Oculus Rift to build procedurally generated maze structures that contain tweets of the given topic, and allows the user to explore these tweets in 3-D space. The procedure for the maze will use characteristics of the tweets to help drive the randomness of the procedural generation.

Project Stack

#Maze Stack
Unity: to deliver 3D representation
Twitter Rest API: to poll twitter for trending topics and gather tweets for viewing
C#: Aggregate of scripts designed to create the maze

Structures and Design
User opens Unity game (Maze class)
Page loads script to initiate construction of a maze (MazeCollection class)
Twitter API polls a trending topic to explore
Twitter API gathers tweets from trending topic and stores them into a set
Scripts creates data representation of the maze
Unity reads maze data (MazeConstruction class)
Unity reads data from Twitter based process, creating a 2D plane of cells or areas to be the “floor plan” of the maze
Populate areas of the maze with floating text of tweets that created the maze, providing the visualization of the data
Processes anything necessary to make the maze “tangible” and “usable”
Handle Control and Oculus (MazeEngine class)
Write control code that captures input to allow for interaction with maze
Have maze display on Oculus Rift
Optional: Command to load new maze instance
Optional: Control for allowing user to control maze query (rather than random trending topic)
Possibly Some Cleanup
