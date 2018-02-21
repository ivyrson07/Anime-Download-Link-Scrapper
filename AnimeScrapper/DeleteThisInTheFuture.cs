
//int bytesProcessed = 0;
//Stream remoteStream;
//Stream localStream;
//HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://animeheaven.eu/search.php?q=dfrag");//http://s6vpxik.animeheaven.eu/force.php?f=D-Fragments--1--1463440700");
//HttpWebResponse response = (HttpWebResponse)request.GetResponse();
//string content = new StreamReader(response.GetResponseStream()).ReadToEnd();

////remoteStream = response.GetResponseStream();

////// Create the local file
////localStream = File.Create(@"C:\Users\Kendrick Khoe\Desktop\Anime Episode 01.mp4");

////// Allocate a 1k buffer
////byte[] buffer = new byte[131072];// 1024];
////int bytesRead;

////// Simple do/while loop to read from stream until
////// no bytes are returned
////do
////{
////    // Read data (up to 1k) from the stream
////    bytesRead = remoteStream.Read(buffer, 0, buffer.Length);

////    // Write the data to the local file
////    localStream.Write(buffer, 0, bytesRead);

////    // Increment total bytes processed
////    bytesProcessed += bytesRead;
////} while (bytesRead > 0);

//string text = "";

//ScrapeManager.InitializeScrapper(AnimeSite.AnimeHeaven);
//            ScrapeManager.CreateRequest(@"http://animeheaven.eu/coversjpg/Is_It_Wrong_to_Try_to_Pick_Up_Girls_in_a_Dungeon.jpg");
//            Image img = Image.FromStream(ScrapeManager.ResponseInMediaFileFormat);

//sampleImg.Image = img;
//            sampleImg.SizeMode = PictureBoxSizeMode.StretchImage;
