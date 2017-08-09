# _Find And Replace_

#### _Find And Replace 08.09.17_

#### By _**Parul Mishra Dubedy**_

## Description

_This Mvc application is called Find And Replace which accepts a single word to find, a replacement word and a sentence. This application will return a modified sentence to the user in which the word to find id replaced by the replacement._

| Behavior  | Input  | Output  |
|---|---|---|
|1.  When the user enter a word, a replacement and a sentence and clicks the `Find and Replace` button, a modified string should be returned.| > Word: "cat" <br> > Replacement: "dog" <br> > Sentence: "I Love cat" |Output:"I Love dog"
|2.  When the user enter a word, a replacement and but not a sentence and clicks the `Find and Replace` button, error message should appear.| > Word: "cat" <br> > Replacement: "dog" <br> > Sentence: |Error Message: Please Enter the sentence.
|3.  When the user enter a word, a sentence but not a replacement and clicks the `Find and Replace` button, error message should appear.| > Word: "cat" <br> > Replacement:  <br> > Sentence:  "I Love cat" |Error Message: Please Enter the replacement.
|4.  When the user does not enter a word, but enters a sentence and a replacement and clicks the `Find and Replace` button, error message should appear.| > Word:  <br> > Replacement: "dog" <br> > Sentence:  "I Love cat" |Error Message: Please Enter the word.
|5.  When the user enters a word, a sentence and a replacement but the word to find is not in the sentence and clicks the `Find and Replace` button, message should appear.| > Word: "cat" <br> > Replacement: "dog" <br> > Sentence: "I like birds"|Message: Sorry not able to find the word "cat".

## Setup/Installation Requirements

* _Clone this repository_

## Known Bugs

* _No known bugs at this time_

## Technologies Used

_HTML_
_CSS_
_BootStrap_
_MVC_
_C#_
_MSTest_
### License

This software is licensed by the MIT License

Copyright (c) 2017 **Parul Mishra Dubedy**
