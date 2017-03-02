<!DOCTYPE html>
<html>
<link href="{{ asset('/css/style.css') }}" rel="stylesheet">
<script src='https://www.google.com/recaptcha/api.js'></script>
@extends('layouts.master')

@section('title')

@section('menu')
    @parent
@stop


@section('content')


<br> <br>


<form method="post" action="traitement.php">

	<div class="g-recaptcha" data-sitekey="6LfaXBcUAAAAAFnXJl33UOK98HoqiACr8zzbCWCH"></div>
	<input type="submit" value="Voter" />

</form>
@stop	
</html>
