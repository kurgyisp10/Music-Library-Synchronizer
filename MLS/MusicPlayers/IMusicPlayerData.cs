﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS
{
    public class SongInfo
    {
        public string songName;
        public string albumName;
        public string artistName;
        public string releaseDate;
        public string songId;
        public List<string> playlists;

        public SongInfo(string songName, string albumName, string artistName, string releaseDate, string songId)
        {
            this.songName = songName;
            this.albumName = albumName;
            this.artistName = artistName;
            this.releaseDate = releaseDate;
            this.songId = songId;
            playlists = new List<string>();
        }

        public override string ToString()
        {
            return songName + " by " + artistName;
        }
    }
    public class PlaylistInfo
    {
        public string playlistId;
        public string playlistName;

        public PlaylistInfo(string playlistId, string playlistName)
        {
            this.playlistId = playlistId;
            this.playlistName = playlistName;
        }

        public override string ToString()
        {
            return playlistName;
        }
    }

    public interface IMusicPlayerData
    {
        Task<string> LoginAsync();
        Task GetPlaylistInfoAsync();
        Task GetSyncSongsAsync(System.Windows.Forms.ListBox.SelectedObjectCollection selectedItems);

        event EventHandler<bool> LoginResult;
        event EventHandler PlaylistInfoResult;
        event EventHandler SyncSongsResult;

        IList<PlaylistInfo> GetPlaylistsInfo();
        Dictionary<string, SongInfo> GetSyncSongs();
    }
}
