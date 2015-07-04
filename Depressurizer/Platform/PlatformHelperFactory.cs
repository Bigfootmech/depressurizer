/*
This file is part of Depressurizer.
Copyright 2011, 2012, 2013 Steve Labbe.

Depressurizer is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Depressurizer is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Depressurizer.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;

namespace Depressurizer
{
    public class PlatformHelperFactory
    {
        private const int PlatformIdUnixOld = 128;
        
        private PlatformHelperFactory ()
        {
        }

        public static IPlatformHelper GetInstance(){
            OperatingSystem currentOs = getOs();

            if (OperatingSystem.Windows == currentOs) {
                return new WindowsHelper();
            }

            if (OperatingSystem.Unix == currentOs) {
                return new LinuxHelper();
            }

            if (OperatingSystem.Osx == currentOs) {
                return new LinuxHelper();
            }

            throw new SystemException("Unsupported Operating system " + currentOs);
        }

        private static OperatingSystem getOs()
        {
            PlatformID pid = Environment.OSVersion.Platform;
            switch (pid) 
            {
            case PlatformID.Win32NT:
            case PlatformID.Win32S:
            case PlatformID.Win32Windows:
            case PlatformID.WinCE:
                return OperatingSystem.Windows;
            case PlatformID.Unix:
            case (PlatformID) PlatformIdUnixOld:
                return OperatingSystem.Unix;
            case PlatformID.MacOSX:
                return OperatingSystem.Osx;
            case PlatformID.Xbox:
            default:
                throw new SystemException("Unsupported Operating system " + pid);
            }
        }

        private enum OperatingSystem 
        {
            Windows, Unix, Osx
        }
    }
}

