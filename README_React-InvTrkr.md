<!-- # Inventory Tracker - web application

#### By Sam Majerus

#### A web application that a Coffee Shop uses to manage/track their currently-available Inventory of Coffee Bean Sacks. 
<br>

## Technologies Used

* JSX  (JS files that can also contain HTML5 code)
* Node.js
  * Node Package Manager (npm)
    * Node Package Executable (npx)
      - Create-React-App (cra)
* Markdown
* React
* React Redux library 
* JSON
* Cascading Style Sheets (CSS)
* Git BASH (Used in: Local Cmd-line Terminal, navigation of local directories)
* GitHub (Remote repositories)
* Draw.io (Diagram(s) of the application's React components.  [Such files contain the end-tag '.drawio' in their name]) 
<br><br>



## Description

The User is greeted with a Splash page listing their current Inventory. For a given Sack, they can Sell 1 Pound of Beans by simply clicking a button.  The application has full Create-Read-Update-Delete (CRUD) functionality. 
A full Sack has 130 LBs of coffee beans of a specified type.  Once the amount of remaining beans in the Sack reaches 0 LBs, the program will not decrement the value any farther.  At this point, the user can choose to delete that Sack or just leave it alone.  

Planned additions:  Add a hidden button for each Sack in the list view with the label "Hide Sack" or "Delete Sack".  It has the same functionality as the button of the same/similar name that is found on a given Sack's Details page, but <em>only</em> becomes visible once the Sack no longer has any Coffee Beans remaining. 
<br><br> 



## Setup/Installation Requirements

* All that's required to run this application -- at minimum -- is: a decently-performing laptop, and a reliable Internet connection.  

* To Clone the program from the GitHub repo to your local machine:

  * 1.) Click the green button labelled 'Code'. Under the 'HTTPS' tab, there are 3 Options. This program will work best with Option 1, so move on to Step 2. <br> 

  * 2.) Copy the link. Then, in Git BASH, navigate to the folder you want to put the files in. This can be your Desktop directory, or a different subfolder, whatever you prefer. Next, still in the Git BASH console, type the following (with the copied-link in place of 'HTTPS') and hit ENTER: 'git clone HTTPS' Several lines of text will come up in the console -- that's the files being copied into whichever directory/folder you're in currently. Then, do the following once your prompt line reappears: While still in the console window, type 'pwd' and press ENTER. This will display your current file path. Copy that by highlighting it and pressing 'Ctrl-C', and then pasting it in an easily-accessible word processor like Notepad for reference. Next, open File Explorer, and navigate to through your files according to that File Path you just copy-pasted for reference. Once you've done this, move on to Step 3. <br>

  * 3.) To ensure that you can find this folder again in the Steps that follow, please do the following: right-click the containing folder (in which the newly-copied files are stored) and select the option that says 'Pin to Quick Access'.  Move on to Step 4. <br>

  * 4.) Open VS Code. Then, click on the page icon at the top of the left-hand toolbar. Then click 'Open Folder'. When the Windows File Explorer window appears, navigate to and select the containing folder you pinned in the previous step. Once you've selected the folder and clicked the button to open the folder in VS Code, move on to Step 5. <br>

  * 5.) Open a New Terminal (shortcut is Ctrl+Shift+`). Then, in the command line, navigate to the "inv-trkr" subdirectory by typing  'cd inv-trkr'  then pressing ENTER.   
  Next, type  'npm install'  and press ENTER. This ensures that everything required to run the program is updated and ready to go.   (Your command prompt will show up again once the operation is complete; DO NOT kill the terminal or close VS Code.) <br>
  Once that's done, move on to the next Section.     (DO NOT Navigate to any other directories between now and then!!  Otherwise, the Program will not run.) <br>


* Running the Program 
  
  * In your Git BASH command line, enter the command  'npm run start' .   The files will be compiled and then the application will be started. Once a new tab opens in your browser, the rest should be self-explanatory. 

  The localhost server application will shut down once the user presses 'Ctrl-C' with the terminal selected.  To run the program again after a given session ends, simply reenter  'npm run start'  as before.
<br><br>


* If you get an error, here are Troubleshooting steps to try <em>(In Order)</em>: 
  * 9 times out of 10, an error message will appear if you try to run the program whilst being in the wrong directory location.  
  To make sure you're in the right place, do the following-- 
    * In your Git Bash command line, enter the command  'pwd'.  The Path leading to your current Folder (a.k.a. Directory) location will be printed out.   
    If the last 2 Directories in that Path DO NOT match the following snippet, then you're located in the wrong place. ('CONTAINER' represents your Containing Folder, which is what Contains the Program's Parent/Root folder):       ./CONTAINER/inv-trkr 

  * If you're in the Right Place:  try entering the command  'npm install'.  Once its process is completed, try entering  'npm run start' again. 

  * Still not working?  Save a copy of this document, then move the Program's folder to the Recycle bin and Delete it. Then, try installing it from GitHub again using the above steps. 

  * If it <em>still</em> won't work:  Please don't hesitate to reach out via Email.  In addition to uncropped screenshots of the issue (send them as Attachments), please also include your Contact Info (preferably with the best method for contacting you).   This allows me to better assist you with Troubleshooting.  
<br><br>

 
* Closing the Program 
  * A. Browser tab & VS Code 
    * Close the browser tab. 
    
    * In VS Code, press 'Ctrl-C' to end the Localhost server application.
    * Next, do  'File > Close Folder'  (or 'Ctrl-K F'). When that operation is complete, you may close VS Code. 

<br><br><br>



## Known Bugs
* If 2 or more Sacks exist in a list, and the User clicks the Sell button for one of them (in the List view), then that Sack is pushed to the bottom, while the others move up one.   (This doesn't happen when there's just one Sack in the List, of course.) 
!-- * If one field is edited for a Sack, but the others are left blank, then those fields will be reset in addition to the edited field. [Fixed with Hooks] --

* When creating a new Sack, the initial value for the 'poundsLeft' property is set to 130, but the Input field still exists on the form page.  (If/when I figure out how to use CSS to hide that Input Box for the NewSackForm only, I'll implement that.   All the User needs to know is that the initial value of the Sack will always be 130 LBs, regardless of what value they enter.) 
<br>


## License

Email me at ladolego@gmail.com for questions, ideas, concerns, or even any issues that you run into. You may also clone or Fork the content in this Repo to fiddle around with it, if you like.

Licensed through MIT. Copyright (c) 11/18/2022, Samuel Majerus. 






!-- 
# Getting Started with Create React App

This project was bootstrapped with [Create React App](https://github.com/facebook/create-react-app).

## Available Scripts

In the project directory, you can run:

### `npm start`

Runs the app in the development mode.\
Open [http://localhost:3000](http://localhost:3000) to view it in your browser.

The page will reload when you make changes.\
You may also see any lint errors in the console.

### `npm test`

Launches the test runner in the interactive watch mode.\
See the section about [running tests](https://facebook.github.io/create-react-app/docs/running-tests) for more information.

### `npm run build`

Builds the app for production to the `build` folder.\
It correctly bundles React in production mode and optimizes the build for the best performance.

The build is minified and the filenames include the hashes.\
Your app is ready to be deployed!

See the section about [deployment](https://facebook.github.io/create-react-app/docs/deployment) for more information.


## Learn More

You can learn more in the [Create React App documentation](https://facebook.github.io/create-react-app/docs/getting-started).

To learn React, check out the [React documentation](https://reactjs.org/).

### Code Splitting

This section has moved here: [https://facebook.github.io/create-react-app/docs/code-splitting](https://facebook.github.io/create-react-app/docs/code-splitting)

### Analyzing the Bundle Size

This section has moved here: [https://facebook.github.io/create-react-app/docs/analyzing-the-bundle-size](https://facebook.github.io/create-react-app/docs/analyzing-the-bundle-size)

### Making a Progressive Web App

This section has moved here: [https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app)

### Advanced Configuration

This section has moved here: [https://facebook.github.io/create-react-app/docs/advanced-configuration](https://facebook.github.io/create-react-app/docs/advanced-configuration)

### Deployment

This section has moved here: [https://facebook.github.io/create-react-app/docs/deployment](https://facebook.github.io/create-react-app/docs/deployment)

### `npm run build` fails to minify

This section has moved here: [https://facebook.github.io/create-react-app/docs/troubleshooting#npm-run-build-fails-to-minify](https://facebook.github.io/create-react-app/docs/troubleshooting#npm-run-build-fails-to-minify) 
-- -->