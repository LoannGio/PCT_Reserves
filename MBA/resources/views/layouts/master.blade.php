<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="Css/style.css" />
    <title>MBA BORDEAUX  @yield('title')</title>
</head>
<body>
    @section('menu')
    <div class="entete">
        <table>
	        <tr>
	        	<td> 
	        		<img src="{{URL::asset('/images/img.jpg')}}" alt="profile Pic" height="200" width="200">
	        	</td>
	        	<td>
	        		<h1> <font size="7"> Musée des Beaux-Arts de Bordeaux </font> </h1>
	        		<marquee direction="right"> * * * Merci pour votre visite sur notre espace de vote * * * </marquee>
	        	</td>
	        </tr>       
	    	
    	</table>
    </div>

    <ul>
        <li><a href="#home">Home</a></li>
        <li><a href="#news">News</a></li>
        <li class="dropdown">
            <a href="javascript:void(0)" class="dropbtn">Dropdown</a>
            <div class="dropdown-content">
            <a href="#">Link 1</a>
            <a href="#">Link 2</a>
            <a href="#">Link 3</a>
            </div>
        </li>
    </ul>
    @show

    @yield('content')
</body>
	<footer>
	     Copyright © 2017 BORDEAUX. Tous droits réservés.
	</footer>    
</html>



