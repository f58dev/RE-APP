<template>
    <div>
      <h1>Add New Property</h1>
      <form @submit.prevent="submitProperty">
        <div>
          <label>Name:</label>
          <input v-model="newProperty.name" required />
        </div>
        <div>
          <label>Location:</label>
          <input v-model="newProperty.location" required />
        </div>
        <div>
          <label>Price Per Night:</label>
          <input type="number" v-model.number="newProperty.pricePerNight" required />
        </div>
        <div>
          <label>Description:</label>
          <textarea v-model="newProperty.description" required></textarea>
        </div>
        <button type="submit">Add Property</button>
      </form>
    </div>
  </template>
  
  <script setup>
  import { ref } from 'vue'
  import { useRouter } from 'vue-router'
  
  const router = useRouter()
  
  const newProperty = ref({
    name: '',
    location: '',
    pricePerNight: 0,
    description: ''
  })
  
  function submitProperty() {
    fetch('http://localhost:5286/properties', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(newProperty.value)
    })
      .then(res => {
        if (res.ok) {
          router.push('/') 
        } else {
          alert('Failed to add property.')
        }
      })
      .catch(err => {
        console.error('Error adding property:', err)
      })
  }
  </script>