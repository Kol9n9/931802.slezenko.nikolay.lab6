using System;
using System.Collections.Generic;
using Lab6.Models;

namespace Lab6.ViewModels.Folders
{
    public class FolderViewModel
    {
        public Folder Folder { get; set; }

        public List<(string name, Guid id)> Path { get; set; }
    }
}