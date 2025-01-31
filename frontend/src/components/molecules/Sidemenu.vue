<script lang="ts" setup>
import { ArrowLeftIcon } from "@heroicons/vue/24/outline";
import IconButton from "../atoms/IconButton.vue";

const { items = [{ icon: ArrowLeftIcon, key: "a" }] } = defineProps<{
  items: {
    icon: Object;
    key: string;
    disabled?: boolean;
    active?: boolean;
    onClick?: () => void;
  }[];
}>();
</script>

<template>
  <div
    class="shadow h-screen sticky pl-2 top-0  max-w-18 flex pt-6 justify-center"
  >
    <div class="pt-16">
      <IconButton
        v-for="btn in items"
        :key="btn.key"
        :active="btn.active"
        :disabled="btn.disabled"
        :icon="btn.icon"
        @click="btn.onClick"
      />
    </div>
	  <div class="justify-self-end h-full ml-2 w-[1px] bg-gradient-to-t from-orange-200 to-cyan-300"></div>
  </div>
</template>
