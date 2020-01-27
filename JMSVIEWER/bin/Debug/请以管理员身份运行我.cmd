@echo off
REG ADD HKEY_CLASSES_ROOT\.jms
REG ADD HKEY_CLASSES_ROOT\.jms /v "" /t REG_SZ /d "jmsfile" /f>NUL
REG ADD HKEY_CLASSES_ROOT\jmsfile
REG ADD HKEY_CLASSES_ROOT\jmsfile /v "" /t REG_SZ /d "jms 加密文件" /f>NUL
REG ADD HKEY_CLASSES_ROOT\jmsfile\shell
REG ADD HKEY_CLASSES_ROOT\jmsfile\shell\open
REG ADD HKEY_CLASSES_ROOT\jmsfile\shell\open\command
REG ADD HKEY_CLASSES_ROOT\jmsfile\DefaultIcon /ve /t REG_SZ /d "%~dp0加密之神文件编辑器.exe,0" /f>NUL
REG ADD HKEY_CLASSES_ROOT\jmsfile\shell\open\command /ve /t REG_SZ /d "\"%~dp0加密之神文件编辑器.exe\" \"%%1\"" /f>NUL
assoc .jms=jmsfile