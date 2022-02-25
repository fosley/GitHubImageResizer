# GitHubImageResizer
A simple program to convert the default BBCode syntax to HTML so you can set picture sizes in GitHub threads.

When you drag a new image into a GitHub thread, it gives you a BBCode tag for the image, something like:
![ImageName](Filename.png)

This program simply finds the parentheses, assumes everything between them is a filename, and spits out HTML.

By setting the Width and Height fields, you can adjust the size of the images.

The program defaults to quick mode, so you drag and drop the image to get BBCode, cut that, tab to this program,
paste into the input box, and it automagically clears the input box (so you're ready for another) and pushes the
HTML text onto your clipboard. So paste into the program then tab back to GitHub and paste the HTML.
