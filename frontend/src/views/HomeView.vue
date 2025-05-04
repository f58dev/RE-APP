<template>
  <div>
    <h1>All Properties</h1>
    <ul>
      <li v-for="property in properties" :key="property.id">
        <strong>{{ property.name }}</strong> - {{ property.pricePerNight }}$
        <p>{{ property.description }}</p>
      </li>
    </ul>
  </div>
</template>

<script>
export default {
  name: "HomeView",
  data() {
    return {
      properties: [],
    };
  },
  mounted() {
    fetch("http://localhost:5286/properties")
      .then((res) => res.json())
      .then((data) => {
        this.properties = data;
      })
      .catch((err) => {
        console.error("Failed to fetch properties:", err);
      });
  },
};
</script>