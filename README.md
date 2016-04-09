\#hashtag_maze

\#Maze Table of Contents
Elevator Pitch
Project Stack
Structures and Design

Elevator Pitch
\#Maze is a web application that builds an interactive visualization of a Twitter topic. It uses Twitter Rest API, Unity, and the Oculus Rift to build procedurally generated maze structures that contain tweets of the given topic, and allows the user to explore these tweets in 3-D space. The procedure for the maze will use characteristics of the tweets to help drive the randomness of the procedural generation.

Project Stack

\#Maze Stack
Unity: to deliver 3D representation
Twitter Rest API: to poll twitter for trending topics and gather tweets for viewing
C#: Aggregate of scripts designed to create the maze

Structures and Design
1. User opens Unity game (Maze class)
2. Page loads script to initiate construction of a maze (MazeCollection class)
  1. Twitter API polls a trending topic to explore
  2. Twitter API gathers tweets from trending topic and stores them into a set
  3. Scripts creates data representation of the maze
3. Unity reads maze data (MazeConstruction class)
  1. Unity reads data from Twitter based process, creating a 2D plane of cells or areas to be the “floor plan” of the maze
  2. Populate areas of the maze with floating text of tweets that created the maze, providing the visualization of the data
  3. Processes anything necessary to make the maze “tangible” and “usable”
4. Handle Control and Oculus (MazeEngine class)
  1. Write control code that captures input to allow for interaction with maze
  2. Have maze display on Oculus Rift
  3. Optional: Command to load new maze instance
  4. Optional: Control for allowing user to control maze query (rather than random trending topic)
5. Possibly Some Cleanup
