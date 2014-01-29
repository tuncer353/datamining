 ::Trun off the echo
 @echo off
 
 echo Minning Tool Politechnika Slaska 
 echo.
 
 if "%1"=="-mode" (
	goto openTool
 ) else (
	echo Use -mode [/mode] to define the type of processing.
	echo     [sgl] to process single file.
	echo     [bth] to process in batch.
	echo.
	goto endError
 )
 
 :openTool
 if exist "%3" (
     echo pasaste el/los parametro/s %*
	 call "Data Mining.exe" %*
 ) else (
     echo Input and Output files must be defined.
 )
 
 :endError
 ::Wait until any key is pressed
 echo.
 