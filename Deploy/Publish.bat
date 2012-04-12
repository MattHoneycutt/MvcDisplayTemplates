@echo off
powershell -NoProfile -ExecutionPolicy unrestricted -Command "& {.\publish.ps1 -PackageName 'MvcDisplayTemplates'; exit $error.Count}"
pause