<!DOCTYPE html>
<html>

@extends('layouts.master')

@section('title')

@section('menu')
    @parent
@stop


@section('content')

<?php


$oeuvre = DB::table('OeuvreParSondage')->whereid($o_id)->first();

echo"<br>";
echo "<img src='{$oeuvre->url_img}' alt='profile Pic' height='200' width='200'>";
echo"<br>";
echo $oeuvre->titre, '<br>';
echo $oeuvre->auteur, '<br>';
echo $oeuvre->description, '<br>';

?>

<br> <br>

<div class="icone">
	<form method="post" action="../../../voter/traitement/<?php echo"$s_id";?>/<?php echo"$o_id";?>/" id ="form">
	    {!! csrf_field() !!}   
			<div class="icone"> 
		 		{!! app('captcha')->display($attributes = [], $lang = "Fr"); !!}
			</div>
		
		<input type="submit" value="Voter" />

	</form>
</div>


@stop	
</html>
