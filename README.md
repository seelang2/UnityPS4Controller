# UnityPS4Controller
This is a simple controller script that maps the controls of a PS4 Controller to serialized events visible in the Editor.

You can simply import the PS4Controller.unitypackage into your Unity project. I included the C# files here for reference. Everything's in the package.

## Basic Usage
1. Make sure you load the PS4Controller Input settings from the included presets to your Input controller: Edit -> Project Settings -> Input, then click the middle 'presets' icon, and select the PS4Controller preset. 

2. Attach the PS4Controller script to the game object you want to control. 

3. Create a handler script and put the methods that will process each control in that script. Make sure the methods are public access and have the appropriate parameters defined. See the 'Callback Handlers' section below.

4. Attach the handler script to the game object.

In the Editor there is an event for each of the PS4 controls. For each control you want to respond to:

5. Click the '+' to add a new handler for that event. 

6. Drag the game object into the object field.

7. Select the class and method you want to get called when the control is activated.

## Callback Handlers
The PS4 has two types of controls - Axis and Buttons.

The Axis controls (left and right sticks, dpad, L2, and R2) are analog and have values between -1 and 1. Their handlers are passed two parameters - string, float. The first parameter is the control name, and the second parameter is the control value. 

The Button controls are simply active or not (boolean), thus they don't have values associated with them. Their handlers are passed one parameter - string. The string contains the name of the control that was pressed.

Note that R2 and L2 are designated both as Axis and Button controls. Their control names are differentiated to reflect which input setting is used. 

### Control Names
Axis:
* LeftStickX
* LeftStickY
* RightStickX
* RightStickY
* DPadX
* DPadY
* L2Axis
* R2Axis

Buttons:
* Square
* X
* Circle
* Triangle
* L1
* L2Button
* L3
* R1
* R2Button
* R3
* PS
* Pad
* Share
* Options

## Debug Flag
There is a flag called 'Show Debug' that defaults to being enabled. This just triggers a console message in PS4Controller to dump a notice of what control was activated and its value, if any.

## Demo Scene
I've included a demo scene called TestScene. There's just a plane and a cube in the scene. The PS4Controller script and a demo CubeController script is attached to the cube, and all the control events are mapped to a couple of test handlers that simply send a message to the console. Take a look at the script settings on the cube in the scene to see how everything is connected.