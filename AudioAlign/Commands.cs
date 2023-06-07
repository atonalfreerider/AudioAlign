﻿//
// AudioAlign: Audio Synchronization and Analysis Tool
// Copyright (C) 2010-2015  Mario Guggenberger <mg@protyposis.net>
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace AudioAlign
{
    static class Commands
    {
        public static readonly RoutedUICommand PlayToggle = new RoutedUICommand(
            "Play/Pause",
            "PlayToggle",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand FileExportVegasEDL = new RoutedUICommand(
            "Export to Vegas EDL",
            "FileExportVegasEDL",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand FileExportSyncXML = new RoutedUICommand(
            "Export Sync XML",
            "FileExportSyncXML",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand FileExportMatchesCSV = new RoutedUICommand(
            "Export Matches to CSV",
            "FileExportMatchesCSV",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand FileProjectAdd = new RoutedUICommand(
            "Add",
            "FileProjectAdd",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand AddAudioFile = new RoutedUICommand(
            "Add Audio File",
            "AddAudioFile",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand FileExportAudioMix = new RoutedUICommand(
            "Export audio mix",
            "FileExportAudioMix",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand FileExportSelectedTracks = new RoutedUICommand(
            "Export selected tracks",
            "FileExportSelectedTracks",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand FileOpenRecentProject = new RoutedUICommand(
            "Open Recent Project",
            "FileOpenRecentProject",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand DebugRefreshMultiTrackViewer = new RoutedUICommand(
            "Refresh MultiTrackViewer",
            "DebugRefreshMultiTrackViewer",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand DebugRefreshPeakStores = new RoutedUICommand(
            "Refresh PeakStores",
            "DebugRefreshPeakStores",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand ViewZoomToFit = new RoutedUICommand(
            "Zoom to Fit",
            "ViewZoomToFit",
            typeof(MainWindow),
            new InputGestureCollection(new[] { new KeyGesture(Key.F, ModifierKeys.Control) })
        );
        public static readonly RoutedUICommand ViewFitTracksVertically = new RoutedUICommand(
            "Resize Track Heights",
            "ViewFitTracksVertically",
            typeof(MainWindow),
            new InputGestureCollection(new[] { new KeyGesture(Key.H, ModifierKeys.Control) })
        );
        public static readonly RoutedUICommand ViewGroupMatchingTracks = new RoutedUICommand(
            "Group Matching Tracks",
            "ViewGroupMatchingTracks",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand ViewOrderTracksByOffset = new RoutedUICommand(
            "Offset",
            "ViewOrderTracksByOffset",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand ViewOrderTracksByLength = new RoutedUICommand(
            "Length",
            "ViewOrderTracksByLength",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand ViewOrderTracksByName = new RoutedUICommand(
            "Name",
            "ViewOrderTracksByName",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand ViewDisplayMatches = new RoutedUICommand(
            "Display Matches",
            "ViewDisplayMatches",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand ViewDisplayTrackHeaders = new RoutedUICommand(
            "Display Track Headers",
            "ViewDisplayTrackHeaders",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand ViewTimelineScreenshotVisible = new RoutedUICommand(
            "Copy Visible Timeline to Clipboard",
            "ViewTimelineScreenshotVisible",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand ViewTimelineScreenshotFull = new RoutedUICommand(
            "Copy Full Timeline to Clipboard",
            "ViewTimelineScreenshotFull",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand MonitorMasterVolume = new RoutedUICommand(
            "Master Volume",
            "MonitorMasterVolume",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand MonitorMasterCorrelation = new RoutedUICommand(
            "Master Correlation",
            "MonitorMasterCorrelation",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand MonitorFrequencyGraph = new RoutedUICommand(
            "Frequency Graph",
            "MonitorFrequencyGraph",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand MonitorSpectrogram = new RoutedUICommand(
            "Spectrogram",
            "MonitorSpectrogram",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand TracksUnmuteAll = new RoutedUICommand(
            "Unmute All",
            "TracksUnmuteAll",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand TracksUnsoloAll = new RoutedUICommand(
            "Unsolo All",
            "TracksUnsoloAll",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand TracksUnlockAll = new RoutedUICommand(
            "Unlock All",
            "TracksUnlockAll",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand TracksResetVolume = new RoutedUICommand(
            "Reset Volume",
            "TracksResetVolume",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand TracksResetColors = new RoutedUICommand(
            "Reset Colors",
            "TracksResetColors",
            typeof(MainWindow)
        );
        public static readonly RoutedUICommand AboutBox = new RoutedUICommand(
            "About",
            "AboutBox",
            typeof(MainWindow)
        );
    }
}
