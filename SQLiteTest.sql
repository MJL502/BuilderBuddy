-- SQLite
SELECT r.RoomName, r.RoomCost, w.WallID, w.Height, w.Length, w.WallCost
FROM Room r
LEFT JOIN Wall w
ON r.RoomID = w.RoomID;
