@echo off
REG ADD HKEY_CLASSES_ROOT\.jms
REG ADD HKEY_CLASSES_ROOT\.jms /v "" /t REG_SZ /d "jmsfile" /f>NUL
REG ADD HKEY_CLASSES_ROOT\jmsfile
REG ADD HKEY_CLASSES_ROOT\jmsfile /v "" /t REG_SZ /d "jms �����ļ�" /f>NUL
REG ADD HKEY_CLASSES_ROOT\jmsfile\shell
REG ADD HKEY_CLASSES_ROOT\jmsfile\shell\open
REG ADD HKEY_CLASSES_ROOT\jmsfile\shell\open\command
REG ADD HKEY_CLASSES_ROOT\jmsfile\DefaultIcon /ve /t REG_SZ /d "%~dp0����֮���ļ��༭��.exe,0" /f>NUL
REG ADD HKEY_CLASSES_ROOT\jmsfile\shell\open\command /ve /t REG_SZ /d "\"%~dp0����֮���ļ��༭��.exe\" \"%%1\"" /f>NUL
assoc .jms=jmsfile