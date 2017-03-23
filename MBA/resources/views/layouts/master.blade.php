<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <link href="{{ asset('/css/style.css') }}" rel="stylesheet">
    
    <link rel="stylesheet" type="text/css" href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.13/css/dataTables.bootstrap.min.css">
    
    <script src="//code.jquery.com/jquery-1.12.4.js"></script>
    <script type="text/javascript" src="{!! asset('js/jquery.dataTables.min.js') !!}"></script>
    <script src="https://cdn.datatables.net/1.10.13/js/dataTables.bootstrap.min.js"></script>

    <script>$(document).ready(function() {
        $('#example').DataTable();
    } );</script>

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
	        		<marquee direction="left"> * * * Merci pour votre visite sur notre espace de vote * * * </marquee>
	        	</td>
	        </tr>       
	    	
    	</table>
    </div>

    <ul>
        <li><a href="/">Accueil</a></li>
        <li><a href="http://www.musba-bordeaux.fr/">Notre site</a></li>
    </ul>
    @show

    @yield('content')
</body>
    <br> <br> <br>
	<footer>
	     Copyright © 2017 BORDEAUX. Tous droits réservés.
	</footer>    
</html>



