﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Coal {
    class Events {
        private static event Action DirectoryChanged;
        private event Action ArrowDownKeyPressed;
        private event Action ArrowUpKeyPressed;
        private event Action EscapeKeyPressed;
        private event Action EnterKeyPressed;
        private event Action F2KeyPressed;
        private event Action F3KeyPressed;
        private event Action F4KeyPressed;
        private event Action F5KeyPressed;
        private event Action F6KeyPressed;
        private event Action F7KeyPressed;
        private event Action F8KeyPressed;
        private event Action F9KeyPressed;
        private event Action F10KeyPressed;
        private event Action TabKeyPressed;
        public static void CallDirectoryChanged() {
            DirectoryChanged?.Invoke();
        }
        public Events(CoalCore core) {
            TabKeyPressed += core.TabHandler;
            F10KeyPressed += core.F10KeyPressedHandler;
        }
        public void Subscribe(Tab window) {
            ArrowDownKeyPressed += window.ArrowDownKeyPressedHandler;
            ArrowUpKeyPressed += window.ArrowUpKeyPressedHandler;
            EscapeKeyPressed += window.EscapeKeyPressedHandler;
            EnterKeyPressed += window.EnterKeyPressedHandler;
            F2KeyPressed += window.F2KeyPressedHandler;
            F3KeyPressed += window.F3KeyPressedHandler;
            F4KeyPressed += window.F4KeyPressHandler;
            F5KeyPressed += window.F5KeyPressedHandler;
            F6KeyPressed += window.F6KeyPressedHandler;
            F7KeyPressed += window.F7KeyPressedHandler;
            F8KeyPressed += window.F8KeyPressedHandler;
            F9KeyPressed += window.F9KeyPressedHandler;
            DirectoryChanged += window.DirectoryChangedEventHandler;
        }
        public void Unsubscribe(Tab window) {
            ArrowDownKeyPressed -= window.ArrowDownKeyPressedHandler;
            ArrowUpKeyPressed -= window.ArrowUpKeyPressedHandler;
            EscapeKeyPressed -= window.EscapeKeyPressedHandler;
            EnterKeyPressed -= window.EnterKeyPressedHandler;
            F2KeyPressed -= window.F2KeyPressedHandler;
            F3KeyPressed -= window.F3KeyPressedHandler;
            F4KeyPressed -= window.F4KeyPressHandler;
            F5KeyPressed -= window.F5KeyPressedHandler;
            F6KeyPressed -= window.F6KeyPressedHandler;
            F7KeyPressed -= window.F7KeyPressedHandler;
            F8KeyPressed -= window.F8KeyPressedHandler;
            F9KeyPressed -= window.F9KeyPressedHandler;
            DirectoryChanged -= window.DirectoryChangedEventHandler;
        }
        public void Selecter(int height) {
            while (true) {
                Console.SetCursorPosition(2, height + 1);
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.DownArrow) {
                    ArrowDownKeyPressed?.Invoke();
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow) {
                    ArrowUpKeyPressed?.Invoke();
                }
                else if (keyInfo.Key == ConsoleKey.Enter) {
                    EnterKeyPressed?.Invoke();
                }
                else if (keyInfo.Key == ConsoleKey.Escape) {
                    EscapeKeyPressed?.Invoke();
                }
                else if (keyInfo.Key == ConsoleKey.F2) {
                    F2KeyPressed?.Invoke();
                }
                else if (keyInfo.Key == ConsoleKey.F3) {
                    F3KeyPressed?.Invoke();
                }
                else if(keyInfo.Key == ConsoleKey.F4) {
                    F4KeyPressed?.Invoke();
                }
                else if (keyInfo.Key == ConsoleKey.F5) {
                    F5KeyPressed?.Invoke();
                }
                else if (keyInfo.Key == ConsoleKey.F6) {
                    F6KeyPressed?.Invoke();
                }
                else if(keyInfo.Key == ConsoleKey.F7) {
                    F7KeyPressed?.Invoke();
                }
                else if(keyInfo.Key == ConsoleKey.F8) {
                    F8KeyPressed?.Invoke();
                }
                else if(keyInfo.Key == ConsoleKey.F9) {
                    F9KeyPressed?.Invoke();
                }
                else if (keyInfo.Key == ConsoleKey.F10) {
                    F10KeyPressed?.Invoke();
                }
                else if(keyInfo.Key == ConsoleKey.Tab) {
                    TabKeyPressed?.Invoke();
                }
            }
        }
    }
}
