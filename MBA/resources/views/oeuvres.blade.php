<!DOCTYPE html>
<html>
<link href="{{ asset('/css/style.css') }}" rel="stylesheet">
@extends('layouts.master')

@section('title')

@section('menu')
    @parent
@stop


@section('content')
  
	<?php
	echo'<br>';
	$oeuvres = DB::table('OeuvreParSondage')->wheresondage_id($n)->get();
	$i=0;
	echo'<table>';
	echo'<tr>';
	foreach ($oeuvres as $oeuvre) {
		if($i==4){
			echo'</tr>';
			echo'<tr>';
			$i=0;
		}else{
			echo'<td>';
			    echo $oeuvre->titre;
				echo "<img src='{$oeuvre->url_img}' alt='profile Pic' height='200' width='200'>";
				echo'<br>';
				echo "<a href='../voter/$oeuvre->id'>Voter</a>","<CENTER><a href='../oeuvre/$oeuvre->id'>Voir Plus</a></CENTER>";
			echo'</td>';
			$i++;
		}	    	
	}
	echo'</table>';
	?>
@stop	
</html>