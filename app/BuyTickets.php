<html>
<head>
    <link rel="stylesheet" href="bower_components/html5-boilerplate/dist/css/normalize.css">
    <link rel="stylesheet" href="bower_components/html5-boilerplate/dist/css/main.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="app.css">
    <a href = Home.php><img src="../app/images/logo.png" class = "logo" href = "Home.html"></a>
    <script src="bower_components/html5-boilerplate/dist/js/vendor/modernizr-2.8.3.min.js"></script>
</head>
<body>
<nav class="navbar navbar-inverse">
    <div class="container-fluid">

        <ul class="nav navbar-nav">
            <li >  <a href="../app/Home.php" class = "MarginChanger">Upcoming Event</a> </li>

            <li >  <a href="BuyTickets.php" class = "MarginChanger">Tickets</a></li>

            <li >  <a  href="../app/Guests.php" class = "MarginChanger">Guests</a></li>

            <li >  <a  href="../app/PastEvents.php" class = "MarginChanger">Past Events</a></li>

            <li >  <a  href="../app/About.php" class = "MarginChanger">About Us</a></li>
        </ul>
    </div>
</nav>
<h1 class = "MenuTitle">Tickets</h1>
<div class = "">
    <form action="BuyTickets.php" method="post">
        <div class="form-row">
            <div class="form-group col-md-6">
                <label for="inputEmail4">Name</label>
                <input name="FirstName" type="text" class="form-control" id="inputEmail4" placeholder="First Name">
            </div>
            <div class="form-group col-md-6">
                <label for="inputPassword4">Family name</label>
                <input name="LastName" type="text" class="form-control" id="inputPassword4" placeholder="FamilyName">
            </div>
        </div>
        <div class="form-group col-md-4">
            <label for="inputAddress">Address</label>
            <input name="Address" type="text" class="form-control" id="inputAddress" placeholder="1234 Main St">
        </div>
        <div class="form-group col-md-4">
            <label for="inputAddress2">Email</label>
            <input type="email" name="Email"  class="form-control" id="inputAddress2" placeholder="Please enter your email...">
        </div>
        <div class="form-group col-md-4">
            <label for="inputAddress2">Phone</label>
            <input type="number" name="PhoneNr"  class="form-control" id="inputAddress2" placeholder="Please enter your phone number...">
        </div>
        <div class="form-group col-md-4">
            <label for="inputAddress2">Date Of Birth</label>
            <input type="date" name="DoB"  class="form-control" id="inputAddress2" placeholder="Please enter your date of birth...">
        </div>
        <div class="form-row">

            <div class="form-group col-md-4">
                <label for="inputState">Skill</label>
                <select typeof="text" name ="Skill" id="inputState" class="form-control" placeholder ="Select your skill group">
                    <option selected></option>
                    <option>Beginner</option>
                    <option>Intermediate</option>
                    <option>Grand Master</option>
                </select>
            </div>
        </div>
        <div class="form-group col-md-4">
            <label for="inputAddress4">Event Account</label>
            <input type="text" name="EventAccID"  class="form-control" id="inputAddress2" placeholder="Please enter your Event Account  ">
        </div>
          
        

        
        <div class="form-group col-md-4">
            
                <label for="inputState">Camping Spot</label>
                <select typeof="text" name ="SpotID"  id="inputState" class="form-control" placeholder ="Would you like a camping spot?">
                    <option selected></option>
                    <option value="Camp1 ">    Camp1 - 55,00 €  </option>
                    <option value="Camp2">     Camp2 - 55,00 €    </option>
                    <option value="Camp3 ">    Camp3 - 55,00 €     </option>
                    <option value="Camp4 ">    Camp4 - 55,00 €      </option>
                    <option value="Camp5 ">    Camp5 - 55,00 €     </option>
                    <option value="VIPCamp1 ">  VIPCamp1 - 60,50 €    </option>
                    <option value="VIPCamp2 ">  VIPCamp2 - 60,50 €         </option>
                    <option value="VIPCamp3 ">  VIPCamp3 - 60,50 €    </option>
                    <option value="VIPCamp4 ">  VIPCamp4 - 60,50 €       </option>
                    <option value="VIPCamp5 ">  VIPCamp5 - 60,50 €     </option>
                    
                </select>
            
            </div>
         <div class="form-row">

            <div class="form-group col-md-4">
                <label for="inputState">Nights Stay</label>
                <select typeof="number" name ="NightsStay" id="inputState" class="form-control" placeholder ="option">
                    <option selected></option>
                    <option>1</option>
                    <option>2</option>
                
                </select>
            </div>
            
          
        </div>
        
        
        
        <input type ="submit" value ="Buy Ticket" name ="Buy">
    </form>
    <div>
    

    </div>
</div>

<?php


$con = mysqli_connect("studmysql01.fhict.local", "dbi362350", "123123");

if(!$con)
{
    echo 'Not connected to server!';
}
if(!mysqli_select_db($con,'dbi362350'))
{
    echo 'Database Not Selected';
}
if(isset($_POST['Buy'])){
$Price = 55.0;
$VipPrice = 60.5;
$NightsStay = $_POST['NightsStay'];
$PhoneNr = $_POST['PhoneNr'];
$FirstName = $_POST['FirstName'];
$LastName = $_POST['LastName'];
$Email = $_POST['Email'];
$DoB = $_POST['DoB'];
$Address = $_POST['Address'];
$Skill = $_POST['Skill'];
$SpotID = $_POST['SpotID'];
$EventAccID = $_POST['EventAccID'];
$HasCamp = 1;
     $check=mysqli_query($con,"select * from customer where SpotID='$SpotID'");
     $checkrows=mysqli_num_rows($check);
//$query ="INSERT INTO customer (Email,FirstName,LastName,PhoneNr,DoB,Address,Skill,EventAccID,SpotID) VALUES ('$Email','$FirstName','$LastName','$PhoneNr','$DoB','$Address','$Skill','$EventAccID','$SpotID') " ;
//$query = "INSERT INTO eventaccount (EventAccID) VALUES ('2344')";
if (empty($Email)){
    $message = "Please fill everything! Camping is optional!";
        echo "<script type='text/javascript'>alert('$message');</script>";
}else if(empty($Address)){
    $message = "Please fill everything! Camping is optional!";
        echo "<script type='text/javascript'>alert('$message');</script>";
}else if (empty($EventAccID)){
    $message = "Please fill everything! Camping is optional!";
        echo "<script type='text/javascript'>alert('$message');</script>";
}else if(empty($DoB)){
    $message = "Please fill everything! Camping is optional!";
        echo "<script type='text/javascript'>alert('$message');</script>";
}else if (empty($Skill)){
    $message = "Please fill everything! Camping is optional!";
        echo "<script type='text/javascript'>alert('$message');</script>";
}else{

if  ($SpotID == "" && $NightsStay == "" )
{
    $query ="INSERT IGNORE INTO customer (Email,FirstName,LastName,PhoneNr,DoB,Address,Skill,EventAccID) VALUES ('$Email','$FirstName','$LastName','$PhoneNr','$DoB','$Address','$Skill','$EventAccID') " ;
    if(mysqli_query($con,$query))
        {
            $message = " Bought succesfully!";
        echo "<script type='text/javascript'>alert('$message');</script>";
        }
        else
        {
        $message = "Please fill everything! Camping is optional!";
        echo "<script type='text/javascript'>alert('$message');</script>";
   
        }
}else if ($SpotID == ""){
    $message = "Please choose a camping spot!";
        echo "<script type='text/javascript'>alert('$message');</script>";
}else if ($NightsStay == ""){
    $message = "Please specify your stay!";
        echo "<script type='text/javascript'>alert('$message');</script>";
}else{
    
    if  (strpos($SpotID,'VIP')!== false )
{
          if($checkrows>0) {
      $message = "Camp spot is taken !";
        echo "<script type='text/javascript'>alert('$message');</script>";
         }
        else{
            
    $query ="INSERT IGNORE  INTO customer (Email,FirstName,LastName,PhoneNr,DoB,Address,Skill,EventAccID,SpotID,PricePerNight,NightsStay,CampReservation) VALUES ('$Email','$FirstName','$LastName','$PhoneNr','$DoB','$Address','$Skill','$EventAccID','$SpotID','$VipPrice','$NightsStay','$HasCamp') " ;
             
    if(mysqli_query($con,$query))
        {
            $message = " Bought succesfully!";
        echo "<script type='text/javascript'>alert('$message');</script>";
        }
        else
        {
        $message = "Please fill everything! Camping is optional!";
        echo "<script type='text/javascript'>alert('$message');</script>";
   
        }
        }
}
    else
    {
         if($checkrows>0) {
      $message = " Camp spot is taken !";
        echo "<script type='text/javascript'>alert('$message');</script>";
         }else{
        $query ="INSERT IGNORE  INTO customer (Email,FirstName,LastName,PhoneNr,DoB,Address,Skill,EventAccID,SpotID,PricePerNight,NightsStay,CampReservation) VALUES ('$Email','$FirstName','$LastName','$PhoneNr','$DoB','$Address','$Skill','$EventAccID','$SpotID','$Price','$NightsStay','$HasCamp') " ;

        if(mysqli_query($con,$query))
        {
            $message = " Bought succesfully!";
        echo "<script type='text/javascript'>alert('$message');</script>";
        }
        else
        {
        $message = "Please fill everything! Camping is optional!";
        echo "<script type='text/javascript'>alert('$message');</script>";
   
        }
        }
    }
}
    


}
};

?>



</body>
</html>

