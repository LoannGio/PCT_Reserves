<!DOCTYPE html>
<html>
@extends('layouts.master')

@section('title')

@section('menu')
    @parent
@stop


@section('content')
	    
	<br><br>    
	<?php
		$oeuvres = DB::table('OeuvreParSondage')->wheresondage_id($n)->get();
		$sondage = DB::table('Sondage')->whereid($n)->first();
		echo"<h1 class='titre'> Liste des oeuvres du sondage : $sondage->titre </h1>";
		echo'<br> <br>';
		echo'<table id="example" class="display" cellspacing="0" width="80%">';
			echo'<thead>';
				echo'<th> Image </th>';
				echo'<th> Titre </th>';
				echo'<th> Auteur </th>';
				echo'<th> Description </th>';
				echo'<th> Détails </th>';
			echo'</thead>';	
			echo'<tbody>';
		foreach ($oeuvres as $oeuvre) {
			echo'<tr>';
				echo'<td>';
					echo'<div class=zoom>';
					echo'<div class=image>';
						echo "<img src='{$oeuvre->url_img}' alt='profile Pic' height='180' width='180'>";
					echo'</div>';
					echo'</div>';			
				echo'</td>';
				echo'<td>';
					echo $oeuvre->titre;
				echo'</td>';
				echo'<td>';
					echo $oeuvre->auteur;
				echo'</td>';
				echo'<td>';
					$description=substr($oeuvre->description,0, 100);
					echo $description."(...)";
				echo'</td>';
				echo'<td>';
					echo "<CENTER><a class='myButton' href='../oeuvre/$n/$oeuvre->id'>Voter</a></CENTER>";
				echo'</td>';	
			echo'</tr>';		
			}
			echo'</tbody>';	    	
		echo'</table>';

	?>
@stop	
</html>