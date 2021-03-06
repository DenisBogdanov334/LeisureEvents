<!DOCTYPE html>
<!--[if lt IE 7]>      <html lang="en" ng-app="myApp" class="no-js lt-ie9 lt-ie8 lt-ie7"> <![endif]-->
<!--[if IE 7]>         <html lang="en" ng-app="myApp" class="no-js lt-ie9 lt-ie8"> <![endif]-->
<!--[if IE 8]>         <html lang="en" ng-app="myApp" class="no-js lt-ie9"> <![endif]-->
<!--[if gt IE 8]><!--> <html lang="en" ng-app="myApp" class="no-js">
    <!--<![endif]-->
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
 
  <meta name="description" content="">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="bower_components/html5-boilerplate/dist/css/normalize.css">
  <link rel="stylesheet" href="bower_components/html5-boilerplate/dist/css/main.css">
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
  <link rel="stylesheet" href="app.css">
    <a href = "Home.php"><img src="../app/images/logo.png" class = "logo"></a>
  <script src="bower_components/html5-boilerplate/dist/js/vendor/modernizr-2.8.3.min.js"></script> 
</head>
    
<body>
<nav class="navbar navbar-inverse">
  <div class="container-fluid" align="center">
    
   <ul class="nav navbar-nav">
      <li >  <a href="../app/Home.php" class = "MarginChanger">Upcoming Event</a> </li>
                
            <li >  <a href="BuyTickets.php" class = "MarginChanger">Tickets</a></li>
                
            <li >  <a  href="../app/Guests.php" class = "MarginChanger">Guests</a></li>
              
            <li >  <a  href="../app/PastEvents.php" class = "MarginChanger">Past Events</a></li>
    
            <li >  <a  href="../app/About.php" class = "MarginChanger">About Us</a></li>
    </ul>
  </div>
</nav>
<h1 class = "MenuTitle"> Chess Tournament </h1>
    <div class = "aboutBorder">
    <img src = "images/chess-600.jpeg" width="570" class = figuresimg>
    <br>
    <p class = info>Come ye Kings, Queens, Rooks and Pawns and join us at our newest event coming up on the 1st of August!
        We are hosting a three day chess tournament at Park Kuierpad where you can come 
        and show off your skills and earn some amazing prizes! Some of your favourite and
        the best in the world chess players are invited to be guests at our tournament. Only
        people above the age of 15 are allowed to participate. The tournament is going to be 
        split into three difficulty levels, so when purchasing a ticket please specify your skill level!
        People who would like to participate in the tournament will be given the opportunity to reserve a
        camping spot on the beautiful Park Kuierpad!
    </p>
    <br>
    <p class = info> At the event, many shops will be present where you can buy a drink or enjoy a meal after a tough 
        game of chess! If you accidentally forgot your camera or charger, you can borrow one from our 
        loan stands until the end of the event.
        If you are not a chess player but still would like to spectate the tournament, you can buy a
        ticket on the spot which has a 10% discount. </p>
    
    
    
    
    <a href="BuyTickets.php"> <input type="button" value="I want to buy a ticket!" class = "ticketbutton"/></a>
    
    
  <div ng-view></div>

  <div><span app-version></span></div>


  <script src="bower_components/angular/angular.js"></script>
  <script src="bower_components/angular-route/angular-route.js"></script>
  <script src="app.js"></script>
  <script src="view1/view1.js"></script>
  <script src="view2/view2.js"></script>
  <script src="components/version/version.js"></script>
  <script src="components/version/version-directive.js"></script>
  <script src="components/version/interpolate-filter.js"></script>
    </div>
</body>
</html>
