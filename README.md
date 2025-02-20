# Pong
Made with Unity 6

## Install
- Clone this repository or download and extract the zip file
- Using Unity Hub, Add this project from disk and open using a Unity 6 Editor
  - Others _might_ be compatible, but no guarantee 

## Challenges
- Add UI elements to the Canvas
  - Add Text that update when the Game Manager Object Updates the score
    - Hint: Try adding a UnityEvent and a Script to the Canvas or Text Object to update the text
  - Add a menu or game over screen
  - Add sounds when the collisions with the ball occur
    - Checkout AudioSource components
- Gameplay
  - Fix the deflection physics of the ball
    - Have a small force deflect the ball of based on where it hits the paddle
      - This is prevent the ball from getting stuck in corners or top of the screen
    - Have the ball speed up quicker
      - Adjust the forced added to the ball on collision with the player
      - Hint: Try using the editor to do this 
