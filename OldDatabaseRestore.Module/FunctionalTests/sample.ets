;#DropDB OldDatabaseRestoreEasyTest

#Application OldDatabaseRestoreWin
#Application OldDatabaseRestoreWeb
#IfDef OldDatabaseRestoreWin

*Action About...
 
*Action OK

#EndIf

#IfDef OldDatabaseRestoreWeb
!Action Navigation(My Details)
#EndIf
