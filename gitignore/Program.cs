// See https://aka.ms/new-console-template for more information
## Игнорировать временные файлы Visual Studio, результаты сборки и
## файлы, созданные популярными надстройками Visual Studio.
##
## Получить последнюю версию от https://github.com/github/gitignore/blob/master/VisualStudio.gitignore

# Пользовательские файлы
*.rsuser
*.suo
*.пользователь
*.userosscache
*.sln.docstates

# Пользовательские файлы (MonoDevelop/Xamarin Studio)
*.userprefs

# Результаты сборки
[Dd]ebug/
[Dd]ebugPublic/
[Rr]elease/
[Rr]eleases/
x64/
x86/
[Aa][Rr][Mm]/
[Aa] [Rr] [Mm]64/
bld/
[Bb]в/
[Oo]bj/
[Ll]og/

# Visual Studio 2015/2017 cache/options directory
.vs/
# Раскомментируйте, если у вас есть задачи, которые создают статические файлы проекта в wwwroot
#wwwroot/

# Visual Studio 2017 автоматически генерируемые файлы
Сгенерированные\ Файлы/

# Результаты теста MSTest
[Tt]est[Rr]esult*/
[Bb]uild[Ll]og.*

# NUNIT
*.VisualState.xml
TestResult.xml

# Результаты сборки проекта ATL
[Dd]ebugPS/
[Rr]eleasePS/
dlldata.c

# Результаты тестов
BenchmarkDotNet.Артефакты/

# .NET Core
project.lock.json
проект.фрагмент.замок. json
артефакты/

# StyleCop
StyleCopReport.xml

# Файлы, созданные Visual Studio
*_i.c
*_p.c
*_h.h
*.ilk
*.meta
*.obj
*.iobj
*.pch
*.pdb
*.ipdb
*.pgc
*.pgd
*.rsp
*.sbr
*.tlb
*.tli
*.tlh
*.tmp
*.tmp_proj
*_wpftmp. csproj
*.log
*.vspscc
*.vssscc
.сборки
*.pidb
*.svclog
*.scc

# Chutzpah Тестовые файлы
_Chutzpah*

# Файлы кэша Visual C++ 
ipch/
*.aps
*.ncb
*.opendb
*.opensdf
*.sdf
*.cachefile
*.VC.db
*.VC.VC.opendb

# Профилировщик Visual Studio
*.psess
*.всп
*.vspx
*.sap

# Файлы трассировки Visual Studio
*.e2e

# Локальное рабочее пространство TFS 2012
$tf/

# Инструментарий автоматизации руководства
*.gpState

# ReSharper-это надстройка для кодирования .NET
_ReSharper*/
*.[Rr]e[Ss]Харпер
*.DotSettings.user

# JustCode-это надстройка для кодирования .NET
.JustCode

# TeamCity-это надстройка для сборки
_TeamCity*

# dotCover-это инструмент покрытия кода
*.dotCover

# AxoCover-это инструмент покрытия кода
.axoCover/*
!.axoCover/settings.json

# Результаты покрытия кода Visual Studio
*.покрытие
*.coveragexml

# NCrunch
_NCrunch_*
.*crunch*.local.xml
nCrunchTemp_*

# MightyMoose
*.mm.*
AutoTest.Net/

# Веб-верстак (sass)
.sass-кэш/

# Выходная папка Installshield
[Ee]xpress/

# DocProject-надстройка генератора документации
DocProject/buildhelp/
DocProject/Help/*.HxT
DocProject/Help/*.HxC
DocProject/Help/*.hhc
DocProject/Help/*.hhk
DocProject/Help/*.hhp
DocProject/Help/Html2
DocProject/Справка/html

# Каталог Click-Once
опубликовать/

# Опубликовать веб-вывод
*.[Pp]ublish.xml
*.azurePubxml
# Note: Comment the next line if you want to checkin your web deploy settings,
# but database connection strings (with potential passwords) will be unencrypted
*.pubxml
*.publishproj

# Microsoft Azure Web App publish settings. Comment the next line if you want to
# checkin your Azure Web App publish settings, but sensitive information contained
# in these scripts will be unencrypted
PublishScripts/

# NuGet Packages
*.nupkg
# The packages folder can be ignored because of Package Restore
**/[Pp]ackages/*
# except build/, which is used as an MSBuild target.
!**/[Pp]ackages/build/
# Uncomment if necessary however generally it will be regenerated when needed
#!**/[Pp]ackages/repositories.config
Файлы project.json # NuGet v3 создают больше игнорируемых файлов
*.nuget.props
*.nuget. targets

# Вывод сборки Microsoft Azure
csx/
*.build.csdef

# Эмулятор Microsoft Azure
ecf/
rcf/

# Каталоги и файлы пакетов приложений Windows Store
Пакеты приложений/
BundleArtifacts/
Пакет.StoreAssociation.xml
_pkginfo.txt
*.appx

# Файлы кэша Visual Studio
# файлы, оканчивающиеся на .cache, можно игнорировать
*.[Cc]боль
# но следите за каталогами, заканчивающимися на .cache
!?*.[Cc]боль/

# Другие
ClientBin/
~$*
*~
*.dbmdl
*.dbproj.schemaview
*.jfm
*.pfx
*.publishsettings
орлеан.codegen.cs

# Включение файлов с сильными именами может представлять угрозу безопасности
# (https://github.com/github/gitignore/pull/2483#issue-259490424)
#*.snk

# Поскольку существует несколько рабочих процессов, раскомментируйте следующую строку, чтобы игнорировать bower_components
# (https://github.com/github/gitignore/pull/1529#issuecomment-104372622)
#bower_компоненты/

# RIA / Проекты Silverlight
Сгенерированный код/

# Резервное копирование и отчет файлов из преобразования старого файла проекта
# в более новую версию Visual Studio. Файлы резервных копий не нужны,
# потому что у нас есть git ;-)
_UpgradeReport_Files/
Резервноекопирование*/
UpgradeLog*.XML
UpgradeLog*.htm
ServiceFabricBackup/
*.rptproj.bak

# Файлы SQL Server
*.mdf
*.ldf
*.ndf

# Проекты бизнес-аналитики
*.rdl.data
*.bim.layout
*.bim_*.settings
*.rptproj.rsuser
*- Backup*.rdl

# Microsoft Fakes
FakesAssemblies/

# GhostDoc plugin setting file
*.GhostDoc.xml

# Node.js Tools for Visual Studio
.ntvs_analysis.dat
node_modules/

# Visual Studio 6 build log
*.plg

# Visual Studio 6 workspace options file
*.opt

# Visual Studio 6 auto-generated workspace file (contains which files were open etc.)
*.vbw

# Visual Studio LightSwitch build output
**/*.HTMLClient/GeneratedArtifacts
**/*.DesktopClient/GeneratedArtifacts
**/*.DesktopClient/ModelManifest.xml
**/*.Server/GeneratedArtifacts
**/*.Server/ModelManifest.xml
_Pvt_Extensions

# Менеджер зависимостей пакетов
.paket/paket.exe
пакет-файлы/

# FAKE - F# Make
.подделка/

# JetBrains Rider
.идея/
*.sln.iml

# CodeRush личные настройки
.cr/личный

# Инструменты Python для Visual Studio (PTVS)
__pycache__/
*.pyc

# Cake - Раскомментируйте, если вы его используете
# инструменты/**
# !инструменты/пакеты.config

# Студия вкладок
*.tss

Файл конфигурации JustMock # Telerik
*.jmconfig

# BizTalk build output
*.btp.cs
*.btm.cs
*.odx.cs
*.xsd.cs

# Результаты анализа пользовательского интерфейса OpenCover
OpenCover/

# Выход локального запуска Azure Stream Analytics
ASALocalRun/

# MSBuild Двоичный и структурированный журнал
*.binlog

# Файл конфигурации отладчика графического процессора NVidia Nsight
*.nvuser

# MFractors (Xamarin productivity tool) рабочая папка
.mfractor/

# Локальная история для Visual Studio
.localhistory/

# BeatPulse healthcheck temp database
healthchecksdb
© 2022 GitHub, Inc.
